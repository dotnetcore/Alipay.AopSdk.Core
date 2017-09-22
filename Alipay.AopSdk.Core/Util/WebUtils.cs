using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

namespace Alipay.AopSdk.Core.Util
{
	/// <summary>
	///     网络工具类。
	/// </summary>
	public sealed class WebUtils
	{
		/// <summary>
		///     请求与响应的超时时间
		/// </summary>
		public int Timeout { get; set; } = 100000;

		/// <summary>
		///     执行HTTP POST请求。
		/// </summary>
		/// <param name="url">请求地址</param>
		/// <param name="parameters">请求参数</param>
		/// <param name="charset">编码字符集</param>
		/// <returns>HTTP响应</returns>
		public string DoPost(string url, IDictionary<string, string> parameters, string charset)
		{
			var req = GetWebRequest(url, "POST");
			req.ContentType = "application/x-www-form-urlencoded;charset=" + charset;

			var postData = Encoding.GetEncoding(charset).GetBytes(BuildQuery(parameters, charset));
			var reqStream = req.GetRequestStream();
			reqStream.Write(postData, 0, postData.Length);
			reqStream.Close();

			var rsp = (HttpWebResponse) req.GetResponse();
			var encoding = Encoding.GetEncoding(rsp.CharacterSet);
			return GetResponseAsString(rsp, encoding);
		}

		/// <summary>
		///     执行HTTP GET请求。
		/// </summary>
		/// <param name="url">请求地址</param>
		/// <param name="parameters">请求参数</param>
		/// <param name="charset">编码字符集</param>
		/// <returns>HTTP响应</returns>
		public string DoGet(string url, IDictionary<string, string> parameters, string charset)
		{
			if (parameters != null && parameters.Count > 0)
				if (url.Contains("?"))
					url = url + "&" + BuildQuery(parameters, charset);
				else
					url = url + "?" + BuildQuery(parameters, charset);

			var req = GetWebRequest(url, "GET");
			req.ContentType = "application/x-www-form-urlencoded;charset=" + charset;

			var rsp = (HttpWebResponse) req.GetResponse();
			var encoding = Encoding.GetEncoding(rsp.CharacterSet);
			return GetResponseAsString(rsp, encoding);
		}

		/// <summary>
		///     执行带文件上传的HTTP POST请求。
		/// </summary>
		/// <param name="url">请求地址</param>
		/// <param name="textParams">请求文本参数</param>
		/// <param name="fileParams">请求文件参数</param>
		/// <param name="charset">编码字符集</param>
		/// <returns>HTTP响应</returns>
		public string DoPost(string url, IDictionary<string, string> textParams, IDictionary<string, FileItem> fileParams,
			string charset)
		{
			// 如果没有文件参数，则走普通POST请求
			if (fileParams == null || fileParams.Count == 0)
				return DoPost(url, textParams, charset);

			var boundary = DateTime.Now.Ticks.ToString("X"); // 随机分隔线

			var req = GetWebRequest(url, "POST");
			req.ContentType = "multipart/form-data;charset=" + charset + ";boundary=" + boundary;

			var reqStream = req.GetRequestStream();
			var itemBoundaryBytes = Encoding.GetEncoding(charset).GetBytes("\r\n--" + boundary + "\r\n");
			var endBoundaryBytes = Encoding.GetEncoding(charset).GetBytes("\r\n--" + boundary + "--\r\n");

			// 组装文本请求参数
			var textTemplate = "Content-Disposition:form-data;name=\"{0}\"\r\nContent-Type:text/plain\r\n\r\n{1}";
			var textEnum = textParams.GetEnumerator();
			while (textEnum.MoveNext())
			{
				var textEntry = string.Format(textTemplate, textEnum.Current.Key, textEnum.Current.Value);
				var itemBytes = Encoding.GetEncoding(charset).GetBytes(textEntry);
				reqStream.Write(itemBoundaryBytes, 0, itemBoundaryBytes.Length);
				reqStream.Write(itemBytes, 0, itemBytes.Length);
			}

			// 组装文件请求参数
			var fileTemplate = "Content-Disposition:form-data;name=\"{0}\";filename=\"{1}\"\r\nContent-Type:{2}\r\n\r\n";
			var fileEnum = fileParams.GetEnumerator();
			while (fileEnum.MoveNext())
			{
				var key = fileEnum.Current.Key;
				var fileItem = fileEnum.Current.Value;
				var fileEntry = string.Format(fileTemplate, key, fileItem.GetFileName(), fileItem.GetMimeType());
				var itemBytes = Encoding.GetEncoding(charset).GetBytes(fileEntry);
				reqStream.Write(itemBoundaryBytes, 0, itemBoundaryBytes.Length);
				reqStream.Write(itemBytes, 0, itemBytes.Length);

				var fileBytes = fileItem.GetContent();
				reqStream.Write(fileBytes, 0, fileBytes.Length);
			}

			reqStream.Write(endBoundaryBytes, 0, endBoundaryBytes.Length);
			reqStream.Close();

			var rsp = (HttpWebResponse) req.GetResponse();
			var encoding = Encoding.GetEncoding(rsp.CharacterSet);
			return GetResponseAsString(rsp, encoding);
		}

		public HttpWebRequest GetWebRequest(string url, string method)
		{
			var req = (HttpWebRequest) WebRequest.Create(url);
//			req.ServicePoint.Expect100Continue = false;
			req.Method = method;
			req.KeepAlive = true;
			req.UserAgent = "Aop4Net";
			req.Timeout = Timeout;
			return req;
		}

		/// <summary>
		///     把响应流转换为文本。
		/// </summary>
		/// <param name="rsp">响应流对象</param>
		/// <param name="encoding">编码方式</param>
		/// <returns>响应文本</returns>
		public string GetResponseAsString(HttpWebResponse rsp, Encoding encoding)
		{
			var result = new StringBuilder();
			Stream stream = null;
			StreamReader reader = null;

			try
			{
				// 以字符流的方式读取HTTP响应
				stream = rsp.GetResponseStream();
				reader = new StreamReader(stream, encoding);

				// 按字符读取并写入字符串缓冲
				var ch = -1;
				while ((ch = reader.Read()) > -1)
				{
					// 过滤结束符
					var c = (char) ch;
					if (c != '\0')
						result.Append(c);
				}
			}
			finally
			{
				// 释放资源
				if (reader != null) reader.Close();
				if (stream != null) stream.Close();
				if (rsp != null) rsp.Close();
			}

			return result.ToString();
		}

		/// <summary>
		///     组装普通文本请求参数。
		/// </summary>
		/// <param name="parameters">Key-Value形式请求参数字典</param>
		/// <returns>URL编码后的请求数据</returns>
		public static string BuildQuery(IDictionary<string, string> parameters, string charset)
		{
			var postData = new StringBuilder();
			var hasParam = false;

			var dem = parameters.GetEnumerator();
			while (dem.MoveNext())
			{
				var name = dem.Current.Key;
				var value = dem.Current.Value;
				// 忽略参数名或参数值为空的参数
				if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(value))
				{
					if (hasParam)
						postData.Append("&");

					postData.Append(name);
					postData.Append("=");

					var encodedValue = HttpUtility.UrlEncode(value, Encoding.GetEncoding(charset));

					postData.Append(encodedValue);
					hasParam = true;
				}
			}

			return postData.ToString();
		}
	}
}