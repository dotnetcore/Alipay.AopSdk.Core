using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Util;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Parser
{
	/// <summary>
	///     AOP JSON响应通用解释器。
	/// </summary>
	public class AopJsonParser<T> : IAopParser<T> where T : AopResponse
	{
		private static readonly Dictionary<string, Dictionary<string, AopAttribute>> attrs =
			new Dictionary<string, Dictionary<string, AopAttribute>>();

		protected static readonly DAopConvert AopJsonConvert = delegate(IAopReader reader, Type type)
		{
			object rsp = null;
			var pas = GetAopAttributes(type);

			var em = pas.GetEnumerator();
			while (em.MoveNext())
			{
				var kvp = em.Current;
				var ta = kvp.Value;
				var itemName = ta.ItemName;
				var listName = ta.ListName;

				if (!reader.HasReturnField(itemName) && (string.IsNullOrEmpty(listName) || !reader.HasReturnField(listName)))
					continue;

				object value = null;
				if (ta.ListType != null)
				{
					value = reader.GetListObjects(listName, itemName, ta.ListType, AopJsonConvert);
				}
				else
				{
					if (typeof(string) == ta.ItemType)
					{
						var tmp = reader.GetPrimitiveObject(itemName);
						if (tmp != null)
							value = tmp.ToString();
					}
					else if (typeof(long) == ta.ItemType)
					{
						var tmp = reader.GetPrimitiveObject(itemName);
						if (tmp != null)
							value = ((IConvertible) tmp).ToInt64(null);
					}
					else if (typeof(bool) == ta.ItemType)
					{
						value = reader.GetPrimitiveObject(itemName);
					}
					else
					{
						value = reader.GetReferenceObject(itemName, ta.ItemType, AopJsonConvert);
					}
				}

				if (value != null)
				{
					if (rsp == null)
						rsp = Activator.CreateInstance(type);
					ta.Method.Invoke(rsp, new[] {value});
				}
			}

			return rsp;
		};


		public string EncryptSourceData(IAopRequest<T> request, string body, string encryptType, string encryptKey,
			string charset)
		{
			if (!"AES".Equals(encryptType))
				throw new AopException("API only support AES!");

			var item = parseEncryptData(request, body);

			var bodyIndexContent = body.Substring(0, item.startIndex);
			var bodyEndexContent = body.Substring(item.endIndex);

			//TODO 解密逻辑
			var bizContent = AlipayEncrypt.AesDencrypt(encryptKey, item.encryptContent, charset);

			return bodyIndexContent + bizContent + bodyEndexContent;
		}

		private static Dictionary<string, AopAttribute> GetAopAttributes(Type type)
		{
			Dictionary<string, AopAttribute> tas = null;
			var inc = attrs.TryGetValue(type.FullName, out tas);

			if (inc && tas != null) // 从缓存中获取类属性元数据
				return tas;
			tas = new Dictionary<string, AopAttribute>();

			var pis = type.GetProperties();
			foreach (var pi in pis)
			{
				var ta = new AopAttribute();
				ta.Method = pi.GetSetMethod();

				// 获取对象属性名称
				var xeas = pi.GetCustomAttributes(typeof(JsonPropertyAttribute), true) as JsonPropertyAttribute[];
				if (xeas != null && xeas.Length > 0)
					ta.ItemName = xeas[0].PropertyName;

				// 获取属性类型
				if (pi.PropertyType.IsGenericType)
				{
					var types = pi.PropertyType.GetGenericArguments();
					ta.ListType = types[0];
				}
				else
				{
					ta.ItemType = pi.PropertyType;
				}

				tas.Add(pi.Name + ta.ItemType + ta.ListType, ta);
			}

			attrs[type.FullName] = tas;
			return tas;
		}

		private static string GetSign(string body)
		{
			var json = JsonConvert.DeserializeObject<IDictionary>(body);
			return (string) json["sign"];
		}

		private static string GetSignSourceData(IAopRequest<T> request, string body)
		{
			var rootNode = request.GetApiName().Replace(".", "_") + AlipayConstants.RESPONSE_SUFFIX;
			var errorRootNode = AlipayConstants.ERROR_RESPONSE;

			var indexOfRootNode = body.IndexOf(rootNode);
			var indexOfErrorRoot = body.IndexOf(errorRootNode);

			string result = null;
			if (indexOfRootNode > 0)
				result = ParseSignSourceData(body, rootNode, indexOfRootNode);
			else if (indexOfErrorRoot > 0)
				result = ParseSignSourceData(body, errorRootNode, indexOfErrorRoot);

			return result;
		}

		private static string ParseSignSourceData(string body, string rootNode, int indexOfRootNode)
		{
			var signDataStartIndex = indexOfRootNode + rootNode.Length + 2;
			var indexOfSign = body.IndexOf("\"" + AlipayConstants.SIGN + "\"");
			if (indexOfSign < 0)
				return null;

			var signDataEndIndex = indexOfSign - 1;
			var length = signDataEndIndex - signDataStartIndex;

			return body.Substring(signDataStartIndex, length);
		}


		/// <summary>
		///     解析加密节点
		/// </summary>
		/// <param name="request"></param>
		/// <param name="body"></param>
		/// <returns></returns>
		private static EncryptParseItem parseEncryptData(IAopRequest<T> request, string body)
		{
			var rootNode = request.GetApiName().Replace(".", "_") + AlipayConstants.RESPONSE_SUFFIX;
			var errorRootNode = AlipayConstants.ERROR_RESPONSE;

			var indexOfRootNode = body.IndexOf(rootNode);
			var indexOfErrorRoot = body.IndexOf(errorRootNode);

			EncryptParseItem result = null;
			if (indexOfRootNode > 0)
				result = ParseEncryptItem(body, rootNode, indexOfRootNode);
			else if (indexOfErrorRoot > 0)
				result = ParseEncryptItem(body, errorRootNode, indexOfErrorRoot);

			return result;
		}

		private static EncryptParseItem ParseEncryptItem(string body, string rootNode, int indexOfRootNode)
		{
			var signDataStartIndex = indexOfRootNode + rootNode.Length + 2;
			var indexOfSign = body.IndexOf("\"" + AlipayConstants.SIGN + "\"");

			var signDataEndIndex = indexOfSign - 1;

			if (signDataEndIndex < 0)
				signDataEndIndex = body.Length - 1;

			var length = signDataEndIndex - signDataStartIndex;

			var encyptContent = body.Substring(signDataStartIndex + 1, length - 2);

			var item = new EncryptParseItem();
			item.encryptContent = encyptContent;
			item.startIndex = signDataStartIndex;
			item.endIndex = signDataEndIndex;


			return item;
		}

		#region IAopParser<T> Members

		public T Parse(string body, string charset)
		{
			T rsp = null;

			IDictionary json = null;
			if (!body.StartsWith("<form") && !body.StartsWith("http"))
			{
				json=JsonConvert.DeserializeObject<IDictionary>(body);
			}
			if (json != null)
			{
				// 忽略根节点的名称
				foreach (var key in json.Keys)
				{
					rsp = JsonConvert.DeserializeObject<T>(json[key].ToString());
					if (rsp != null)
						break;
				}

			}

			if (rsp == null)
				rsp = Activator.CreateInstance<T>();

			rsp.Body = body;

			return rsp;
		}


		public SignItem GetSignItem(IAopRequest<T> request, string responseBody)
		{
			if (string.IsNullOrEmpty(responseBody))
				return null;

			var signItem = new SignItem();
			var sign = GetSign(responseBody);
			signItem.Sign = sign;

			var signSourceData = GetSignSourceData(request, responseBody);
			signItem.SignSourceDate = signSourceData;

			return signItem;
		}

		#endregion
	}
}
