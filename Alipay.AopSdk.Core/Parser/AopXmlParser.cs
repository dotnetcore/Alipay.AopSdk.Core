using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Util;

namespace Alipay.AopSdk.Core.Parser
{
	/// <summary>
	///     AOP XML响应通用解释器。
	/// </summary>
	public class AopXmlParser<T> : IAopParser<T> where T : AopResponse
	{
		private static readonly Regex regex = new Regex("<(\\w+?)[ >]", RegexOptions.Compiled);
		private static readonly Dictionary<string, XmlSerializer> parsers = new Dictionary<string, XmlSerializer>();


		public string EncryptSourceData(IAopRequest<T> request, string body, string encryptType, string encryptKey,
			string charset)
		{
			var item = ParseEncryptData(request, body);

			var bodyIndexContent = body.Substring(0, item.startIndex);
			var bodyEndContent = body.Substring(item.endIndex);
			var encryptContent = AlipayEncrypt.AesDencrypt(encryptKey, item.encryptContent, charset);

			return bodyIndexContent + encryptContent + bodyEndContent;
		}

		/// <summary>
		///     获取XML响应的根节点名称
		/// </summary>
		private string GetRootElement(string body)
		{
			var match = regex.Match(body);
			if (match.Success)
				return match.Groups[1].ToString();
			throw new AopException("Invalid XML response format!");
		}

		private static string GetSign(string body)
		{
			var signNodeName = "<" + AlipayConstants.SIGN + ">";
			var signEndNodeName = "</" + AlipayConstants.SIGN + ">";

			var indexOfSignNode = body.IndexOf(signNodeName);
			var indexOfSignEndNode = body.IndexOf(signEndNodeName);

			if (indexOfSignNode < 0 || indexOfSignEndNode < 0)
				return null;

			//  签名
			var startPos = indexOfSignNode + signNodeName.Length;
			return body.Substring(startPos, indexOfSignEndNode - startPos);
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
			//  第一个字母+长度+>
			var signDataStartIndex = indexOfRootNode + rootNode.Length + 1;
			var indexOfSign = body.IndexOf("<" + AlipayConstants.SIGN);
			if (indexOfSign < 0)
				return null;

			// 签名前减去
			var signDataEndIndex = indexOfSign;

			return body.Substring(signDataStartIndex, signDataEndIndex - signDataStartIndex);
		}


		private static EncryptParseItem ParseEncryptData(IAopRequest<T> request, string body)
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
			//  第一个字母+长度+>
			var signDataStartIndex = indexOfRootNode + rootNode.Length + 1;

			var xmlStartNode = "<" + AlipayConstants.ENCRYPT_NODE_NAME + ">";
			var xmlEndNode = "</" + AlipayConstants.ENCRYPT_NODE_NAME + ">";
			var indexOfEncryptNode = body.IndexOf(xmlEndNode);

			if (indexOfEncryptNode < 0)
			{
				var item = new EncryptParseItem();
				item.encryptContent = null;
				item.startIndex = 0;
				item.endIndex = 0;

				return item;
			}

			var startIndex = signDataStartIndex + xmlStartNode.Length;
			var bizLen = indexOfEncryptNode - startIndex;

			var encryptBizContent = body.Substring(startIndex, bizLen);

			var item2 = new EncryptParseItem();
			item2.encryptContent = encryptBizContent;
			item2.startIndex = signDataStartIndex;
			item2.endIndex = indexOfEncryptNode + xmlEndNode.Length;

			return item2;
		}

		#region IAopParser<T> Members

		public T Parse(string body, string charset)
		{
			XmlSerializer serializer = null;
			var rootTagName = GetRootElement(body);

			var inc = parsers.TryGetValue(rootTagName, out serializer);
			if (!inc || serializer == null)
			{
				var rootAttrs = new XmlAttributes();
				rootAttrs.XmlRoot = new XmlRootAttribute(rootTagName);

				var attrOvrs = new XmlAttributeOverrides();
				attrOvrs.Add(typeof(T), rootAttrs);

				serializer = new XmlSerializer(typeof(T), attrOvrs);
				parsers[rootTagName] = serializer;
			}

			object obj = null;
			Encoding encoding = null;
			if (string.IsNullOrEmpty(charset))
				encoding = Encoding.UTF8;
			else
				encoding = Encoding.GetEncoding(charset);
			using (Stream stream = new MemoryStream(encoding.GetBytes(body)))
			{
				obj = serializer.Deserialize(stream);
			}

			var rsp = (T) obj;
			if (rsp != null)
				rsp.Body = body;
			return rsp;
		}


		public SignItem GetSignItem(IAopRequest<T> request, string reponseBody)
		{
			if (string.IsNullOrEmpty(reponseBody))
				return null;

			var signItem = new SignItem();
			var sign = GetSign(reponseBody);
			signItem.Sign = sign;

			var signSourceData = GetSignSourceData(request, reponseBody);
			signItem.SignSourceDate = signSourceData;

			return signItem;
		}

		#endregion
	}
}