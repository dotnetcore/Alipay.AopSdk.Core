using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Alipay.AopSdk.Core.Parser;
using Alipay.AopSdk.Core.Util;

namespace Alipay.AopSdk.Core
{
	public class AlipayMobilePublicMultiMediaClient : IAopClient
	{
		public const string APP_ID = "app_id";
		public const string FORMAT = "format";
		public const string METHOD = "method";
		public const string TIMESTAMP = "timestamp";
		public const string VERSION = "version";
		public const string SIGN_TYPE = "sign_type";
		public const string ACCESS_TOKEN = "auth_token";
		public const string SIGN = "sign";
		public const string TERMINAL_TYPE = "terminal_type";
		public const string TERMINAL_INFO = "terminal_info";
		public const string PROD_CODE = "prod_code";
		public const string APP_AUTH_TOKEN = "app_auth_token";
		private readonly string appId;
		private readonly string charset;
		private string format;
		private readonly string privateKeyPem;
		private readonly string serverUrl;
		private readonly string signType = "RSA";

		private string version;

		private readonly WebUtils webUtils;

		public string Version
		{
			get => version != null ? version : "1.0";
			set => version = value;
		}

		public string Format
		{
			get => format != null ? format : "json";
			set => format = value;
		}

		public T PageExecute<T>(IAopRequest<T> request) where T : AopResponse
		{
			throw new NotImplementedException();
		}

		public T PageExecute<T>(IAopRequest<T> request, string session, string reqMethod) where T : AopResponse
		{
			throw new NotImplementedException();
		}

		public T SdkExecute<T>(IAopRequest<T> request) where T : AopResponse
		{
			throw new NotImplementedException();
		}

	    public Task<T> PageExecuteAsync<T>(IAopRequest<T> request) where T : AopResponse
	    {
	        throw new NotImplementedException();
	    }

	    public Task<T> PageExecuteAsync<T>(IAopRequest<T> request, string accessToken, string reqMethod) where T : AopResponse
	    {
	        throw new NotImplementedException();
	    }

	    public Task<T> ExecuteAsync<T>(IAopRequest<T> request) where T : AopResponse
	    {
	        throw new NotImplementedException();
	    }

	    public Task<T> ExecuteAsync<T>(IAopRequest<T> request, string accessToken) where T : AopResponse
	    {
	        throw new NotImplementedException();
	    }

	    public Task<T> ExecuteAsync<T>(IAopRequest<T> request, string accessToken, string appAuthToken) where T : AopResponse
	    {
	        throw new NotImplementedException();
	    }

	    private AopResponse DoGet(AopDictionary parameters, Stream outStream)
	    {
	        return AsyncHelper.RunSync(async () => await DoGetAsync(parameters, outStream));
	    }

        private async Task<AopResponse> DoGetAsync(AopDictionary parameters, Stream outStream)
		{
			AlipayMobilePublicMultiMediaDownloadResponse response = null;

			var url = serverUrl;
			if (parameters != null && parameters.Count > 0)
				if (url.Contains("?"))
					url = url + "&" + WebUtils.BuildQuery(parameters, charset);
				else
					url = url + "?" + WebUtils.BuildQuery(parameters, charset);

		    var client = webUtils.ConnectionPool.GetClient();
            var query=new Uri(url).Query;
		    var resp = await client.GetAsync(query);
		    if (resp.StatusCode == HttpStatusCode.OK)
		    {

		        var body = await resp.Content.ReadAsStringAsync();
		        IAopParser<AlipayMobilePublicMultiMediaDownloadResponse> tp =
		            new AopJsonParser<AlipayMobilePublicMultiMediaDownloadResponse>();
		        response = tp.Parse(body, charset);
            }
			else
			{
				response = new AlipayMobilePublicMultiMediaDownloadResponse();
			}
			return response;
		}

		/// <summary>
		///     把响应流转换为文本。
		/// </summary>
		/// <param name="rsp">响应流对象</param>
		/// <param name="encoding">编码方式</param>
		/// <returns>响应文本</returns>
		public void GetResponseAsStream(Stream outStream, HttpWebResponse rsp)
		{
			var result = new StringBuilder();
			Stream stream = null;
			StreamReader reader = null;
			BinaryWriter writer = null;

			try
			{
				// 以字符流的方式读取HTTP响应
				stream = rsp.GetResponseStream();
				reader = new StreamReader(stream);

				writer = new BinaryWriter(outStream);

				//stream.CopyTo(outStream);
				var length = Convert.ToInt32(rsp.ContentLength);
				var buffer = new byte[length];
				var rc = 0;
				while ((rc = stream.Read(buffer, 0, length)) > 0)
					outStream.Write(buffer, 0, rc);
				outStream.Flush();
				outStream.Close();
			}
			finally
			{
				// 释放资源
				if (reader != null) reader.Close();
				if (stream != null) stream.Close();
				if (rsp != null) rsp.Close();
			}
		}

		#region DefaultAopClient Constructors

		public AlipayMobilePublicMultiMediaClient(string serverUrl, string appId, string privateKeyPem)
		{
			this.appId = appId;
			this.privateKeyPem = privateKeyPem;
			this.serverUrl = serverUrl;
			webUtils = new WebUtils(serverUrl);
		}

		public AlipayMobilePublicMultiMediaClient(string serverUrl, string appId, string privateKeyPem, string format)
			: this(serverUrl, appId, privateKeyPem)
		{
			this.format = format;
		}

		public AlipayMobilePublicMultiMediaClient(string serverUrl, string appId, string privateKeyPem, string format,
			string charset)
			: this(serverUrl, appId, privateKeyPem, format)
		{
			this.charset = charset;
		}

		public AlipayMobilePublicMultiMediaClient(string serverUrl, string appId, string privateKeyPem, string format,
			string version, string signType)
			: this(serverUrl, appId, privateKeyPem, format)
		{
			this.version = version;
			this.signType = signType;
		}


		#endregion

		#region IAopClient Members

		public T Execute<T>(IAopRequest<T> request) where T : AopResponse
		{
			return Execute(request, null);
		}

		public T Execute<T>(IAopRequest<T> request, string accessToken) where T : AopResponse
		{
			return Execute(request, accessToken, null);
		}

		public T Execute<T>(IAopRequest<T> request, string accessToken, string appAuthToken) where T : AopResponse
		{
			var multiMediaDownloadRequest = (AlipayMobilePublicMultiMediaDownloadRequest) request;
			// 添加协议级请求参数
			var txtParams = new AopDictionary(request.GetParameters());
			txtParams.Add(METHOD, request.GetApiName());
			txtParams.Add(VERSION, Version);
			txtParams.Add(APP_ID, appId);
			txtParams.Add(FORMAT, format);
			txtParams.Add(TIMESTAMP, DateTime.Now);
			txtParams.Add(ACCESS_TOKEN, accessToken);
			txtParams.Add(SIGN_TYPE, signType);
			txtParams.Add(TERMINAL_TYPE, request.GetTerminalType());
			txtParams.Add(TERMINAL_INFO, request.GetTerminalInfo());
			txtParams.Add(PROD_CODE, request.GetProdCode());

			if (!string.IsNullOrEmpty(appAuthToken))
				txtParams.Add(APP_AUTH_TOKEN, appAuthToken);


			// 添加签名参数
			txtParams.Add(SIGN, AopUtils.SignAopRequest(txtParams, privateKeyPem, charset, signType));

			var outStream = multiMediaDownloadRequest.stream;
			var rsp = DoGet(txtParams, outStream);

			return (T) rsp;
		}

		#endregion
	}
}