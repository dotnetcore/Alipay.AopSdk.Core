using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Alipay.AopSdk.Core.Util
{
	/// <summary>
	/// 网络工具类。
	/// </summary>
	public sealed class WebUtils
	{

	    internal readonly WebUtilsHttpConnectionPool ConnectionPool;

	    public WebUtils(string server,int poolSize=30)
	    {
	        ConnectionPool = new WebUtilsHttpConnectionPool(server, poolSize);
	    }


		/// <summary>
		///     执行HTTP POST请求。
		/// </summary>
		/// <param name="url">请求地址</param>
		/// <param name="parameters">请求参数</param>
		/// <param name="charset">编码字符集</param>
		/// <returns>HTTP响应</returns>
		public string DoPost(string url, IDictionary<string, string> parameters, string charset)
		{
		   return AsyncHelper.RunSync(async () => await DoPostAsync(url,parameters,charset));
		}

	    /// <summary>
	    ///     执行HTTP POST请求。
	    /// </summary>
	    /// <param name="url">请求地址</param>
	    /// <param name="parameters">请求参数</param>
	    /// <param name="charset">编码字符集</param>
	    /// <returns>HTTP响应</returns>
	    public async Task<string> DoPostAsync(string url, IDictionary<string, string> parameters, string charset)
	    {
	        try
	        {

	            var encoding = Encoding.GetEncoding(charset);
	            var client = ConnectionPool.GetClient();
	            var query = new Uri(url).Query;
	            var content = new StringContent(BuildQuery(parameters, charset), encoding, "application/x-www-form-urlencoded");

	            var resp = await client.PostAsync(query, content);
	            var result = await resp.Content.ReadAsStringAsync();

	            ConnectionPool.ReturnClient(client);
	            return result;
            }
	        catch (Exception e)
	        {
	            Console.WriteLine(e.ToString());
	            throw e;
	        }

	    }

	    public string DoGet(string url, IDictionary<string, string> parameters, string charset)
	    {
	        return AsyncHelper.RunSync(async () => await DoGetAsync(url, parameters, charset));
        }

        /// <summary>
        ///  执行HTTP GET请求。
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="parameters">请求参数</param>
        /// <param name="charset">编码字符集</param>
        /// <returns>HTTP响应</returns>
        public async Task<string> DoGetAsync(string url, IDictionary<string, string> parameters, string charset)
		{
		    try
		    {

		        if (parameters != null && parameters.Count > 0)
		            if (url.Contains("?"))
		                url = url + "&" + BuildQuery(parameters, charset);
		            else
		                url = url + "?" + BuildQuery(parameters, charset);

		        var query = new Uri(url).Query;
		        var client = ConnectionPool.GetClient();
		        var result = await client.GetStringAsync(query);
		        ConnectionPool.ReturnClient(client);
		        return result;
            }
		    catch (Exception e)
		    {
		        Console.WriteLine(e);
		        throw;
		    }
		}

	    /// <summary>
	    /// 执行带文件上传的HTTP POST请求。
	    /// </summary>
	    /// <param name="url">请求地址</param>
	    /// <param name="textParams">请求文本参数</param>
	    /// <param name="fileParams">请求文件参数</param>
	    /// <param name="charset">编码字符集</param>
	    /// <returns>HTTP响应</returns>
	    public string DoPost(string url, IDictionary<string, string> textParams,
	        IDictionary<string, FileItem> fileParams,
	        string charset)
	    {
	        return AsyncHelper.RunSync(async () => await DoPostAsync(url, textParams, fileParams, charset));
        }

        /// <summary>
        /// 执行带文件上传的HTTP POST请求。
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="textParams">请求文本参数</param>
        /// <param name="fileParams">请求文件参数</param>
        /// <param name="charset">编码字符集</param>
        /// <returns>HTTP响应</returns>
        public async Task<string> DoPostAsync(string url, IDictionary<string, string> textParams, IDictionary<string, FileItem> fileParams,
			string charset)
		{
			// 如果没有文件参数，则走普通POST请求
			if (fileParams == null || fileParams.Count == 0)
				return await DoPostAsync(url, textParams, charset);

		    var encoding = Encoding.GetEncoding(charset);

            var client = ConnectionPool.GetClient();
            var query = new Uri(url).Query;

            using (var content = new MultipartFormDataContent("Upload----" + DateTime.Now.ToString(CultureInfo.InvariantCulture)))
		    {
		        // 组装文本请求参数
                using (var textEnum = textParams.GetEnumerator())
		        {
		            while (textEnum.MoveNext())
		            {
		                var streamContent = new StreamContent(new MemoryStream(encoding.GetBytes(textEnum.Current.Value)));
		                streamContent.Headers.ContentType = new MediaTypeHeaderValue("text/plain");
		                streamContent.Headers.ContentDisposition=new ContentDispositionHeaderValue($"form-data;name=\"{textEnum.Current.Key}\"");
                        content.Add(streamContent);
                    }
		        }
		        // 组装文件请求参数
                using (var fileEnum = fileParams.GetEnumerator())
		        {
		            while (fileEnum.MoveNext())
		            {
		                var key = fileEnum.Current.Key;
		                var fileItem = fileEnum.Current.Value;
		                var streamContent = new StreamContent(new MemoryStream(fileItem.GetContent()));
		                streamContent.Headers.ContentType = new MediaTypeHeaderValue(fileItem.GetMimeType());
		                streamContent.Headers.ContentDisposition = new ContentDispositionHeaderValue($"form-data;name=\"{key}\";filename=\"{fileItem.GetFileName()}\"");
		                content.Add(streamContent);
                    }
                }

		        var resp = await client.PostAsync(query, content);
		        var result = await resp.Content.ReadAsStringAsync();
		        ConnectionPool.ReturnClient(client);
		        return result;
		    }
		}

	    /// <summary>
	    ///     组装普通文本请求参数。
	    /// </summary>
	    /// <param name="parameters">Key-Value形式请求参数字典</param>
	    /// <param name="charset">编码</param>
	    /// <returns>URL编码后的请求数据</returns>
	    public static string BuildQuery(IDictionary<string, string> parameters, string charset)
		{
			var postData = new StringBuilder();
			var hasParam = false;

		    using (var dem = parameters.GetEnumerator())
		    {
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
}