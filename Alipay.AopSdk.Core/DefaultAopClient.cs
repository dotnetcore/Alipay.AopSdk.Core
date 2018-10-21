using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Alipay.AopSdk.Core.Parser;
using Alipay.AopSdk.Core.Util;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core
{
    /// <inheritdoc />
    /// <summary>
    /// AOP客户端。
    /// </summary>
    public class DefaultAopClient : IAopClient
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
        public const string NOTIFY_URL = "notify_url";
        public const string CHARSET = "charset";
        public const string ENCRYPT_TYPE = "encrypt_type";
        public const string BIZ_CONTENT = "biz_content";
        public const string APP_AUTH_TOKEN = "app_auth_token";
        public const string RETURN_URL = "return_url";
        private readonly string alipayPublicKey;
        private string charset;
        private readonly string encyptKey;
        private readonly string encyptType = "AES";
        private string format;
        //private readonly string httpmethod;
        private readonly bool keyFromFile;

        public string notify_url;
        private readonly string privateKeyPem;
        public string return_url;
        private readonly string serverUrl;
        private readonly string signType = "RSA";

        private string version;

        private readonly WebUtils webUtils;

        public string Version
        {
            get => version ?? "1.0";
            set => version = value;
        }

        public string Format
        {
            get => format ?? "json";
            set => format = value;
        }

        public string AppId { get; set; }

        #region IAopClient Members

        public T PageExecute<T>(IAopRequest<T> request) where T : AopResponse
        {
            return PageExecute(request, null, "POST");
        }

        public async Task<T> PageExecuteAsync<T>(IAopRequest<T> request) where T : AopResponse
        {
            return await PageExecuteAsync(request, null, "POST");
        }

        #endregion

        #region IAopClient Members

        public T PageExecute<T>(IAopRequest<T> request, string accessToken, string reqMethod) where T : AopResponse
        {
            if (string.IsNullOrEmpty(charset))
                charset = "utf-8";

            string apiVersion = !string.IsNullOrEmpty(request.GetApiVersion()) ? request.GetApiVersion() : Version;
            var txtParams = new AopDictionary(request.GetParameters());

            // 序列化BizModel
            txtParams = SerializeBizModel(txtParams, request);

            // 添加协议级请求参数
            //AopDictionary txtParams = new AopDictionary(request.GetParameters());
            txtParams.Add(METHOD, request.GetApiName());
            txtParams.Add(VERSION, apiVersion);
            txtParams.Add(APP_ID, AppId);
            txtParams.Add(FORMAT, format);
            txtParams.Add(TIMESTAMP, DateTime.Now);
            txtParams.Add(ACCESS_TOKEN, accessToken);
            txtParams.Add(SIGN_TYPE, signType);
            txtParams.Add(TERMINAL_TYPE, request.GetTerminalType());
            txtParams.Add(TERMINAL_INFO, request.GetTerminalInfo());
            txtParams.Add(PROD_CODE, request.GetProdCode());
            txtParams.Add(NOTIFY_URL, request.GetNotifyUrl());
            txtParams.Add(CHARSET, charset);
            //txtParams.Add(RETURN_URL, this.return_url);
            txtParams.Add(RETURN_URL, request.GetReturnUrl());
            //字典排序
            IDictionary<string, string> sortedTxtParams = new SortedDictionary<string, string>(txtParams);
            txtParams = new AopDictionary(sortedTxtParams)
            {
                // 排序返回字典类型添加签名参数
                { SIGN, AopUtils.SignAopRequest(sortedTxtParams, privateKeyPem, charset, keyFromFile, signType) }
            };

            // 是否需要上传文件
            string body;

            if (request is IAopUploadRequest<T> uRequest)
            {
                var fileParams = AopUtils.CleanupDictionary(uRequest.GetFileParameters());
                body = webUtils.DoPost(serverUrl + "?" + CHARSET + "=" + charset, txtParams, fileParams, charset);
            }
            else
            {
                if (reqMethod.Equals("GET"))
                {
                    //直接调用DoGet方法请求
                    //body=webUtils .DoGet (this.serverUrl ,txtParams ,this.charset);
                    //拼接get请求的url
                    var tmpUrl = serverUrl;
                    if (txtParams != null && txtParams.Count > 0)
                        tmpUrl = tmpUrl.Contains("?")
                            ? tmpUrl + "&" + WebUtils.BuildQuery(txtParams, charset)
                            : tmpUrl + "?" + WebUtils.BuildQuery(txtParams, charset);
                    body = tmpUrl;
                }
                else
                {
                    //直接调用DoPost方法请求
                    // body = webUtils.DoPost(this.serverUrl, txtParams, this.charset);
                    //输出post表单
                    body = BuildHtmlRequest(txtParams, reqMethod, reqMethod);
                }
            }

            T rsp = null;
            IAopParser<T> parser = null;
            if ("xml".Equals(format))
            {
                parser = new AopXmlParser<T>();
                rsp = parser.Parse(body, charset);
            }
            else
            {
                parser = new AopJsonParser<T>();
                rsp = parser.Parse(body, charset);
            }

            //验签
            // CheckResponseSign(request, rsp, parser, this.alipayPublicKey, this.charset);
            return rsp;
        }

        public async Task<T> PageExecuteAsync<T>(IAopRequest<T> request, string accessToken, string reqMethod) where T : AopResponse
        {
            if (string.IsNullOrEmpty(charset))
                charset = "utf-8";

            string apiVersion = !string.IsNullOrEmpty(request.GetApiVersion()) ? request.GetApiVersion() : Version;
            var txtParams = new AopDictionary(request.GetParameters());

            // 序列化BizModel
            txtParams = SerializeBizModel(txtParams, request);

            // 添加协议级请求参数
            //AopDictionary txtParams = new AopDictionary(request.GetParameters());
            txtParams.Add(METHOD, request.GetApiName());
            txtParams.Add(VERSION, apiVersion);
            txtParams.Add(APP_ID, AppId);
            txtParams.Add(FORMAT, format);
            txtParams.Add(TIMESTAMP, DateTime.Now);
            txtParams.Add(ACCESS_TOKEN, accessToken);
            txtParams.Add(SIGN_TYPE, signType);
            txtParams.Add(TERMINAL_TYPE, request.GetTerminalType());
            txtParams.Add(TERMINAL_INFO, request.GetTerminalInfo());
            txtParams.Add(PROD_CODE, request.GetProdCode());
            txtParams.Add(NOTIFY_URL, request.GetNotifyUrl());
            txtParams.Add(CHARSET, charset);
            //txtParams.Add(RETURN_URL, this.return_url);
            txtParams.Add(RETURN_URL, request.GetReturnUrl());
            //字典排序
            IDictionary<string, string> sortedTxtParams = new SortedDictionary<string, string>(txtParams);
            txtParams = new AopDictionary(sortedTxtParams)
            {
                // 排序返回字典类型添加签名参数
                { SIGN, AopUtils.SignAopRequest(sortedTxtParams, privateKeyPem, charset, keyFromFile, signType) }
            };

            // 是否需要上传文件
            string body;

            if (request is IAopUploadRequest<T> uRequest)
            {
                var fileParams = AopUtils.CleanupDictionary(uRequest.GetFileParameters());
                body = await webUtils.DoPostAsync(serverUrl + "?" + CHARSET + "=" + charset, txtParams, fileParams, charset);
            }
            else
            {
                if (reqMethod.Equals("GET"))
                {
                    //直接调用DoGet方法请求
                    //body=webUtils .DoGet (this.serverUrl ,txtParams ,this.charset);
                    //拼接get请求的url
                    var tmpUrl = serverUrl;
                    if (txtParams != null && txtParams.Count > 0)
                        tmpUrl = tmpUrl.Contains("?")
                            ? tmpUrl + "&" + WebUtils.BuildQuery(txtParams, charset)
                            : tmpUrl + "?" + WebUtils.BuildQuery(txtParams, charset);
                    body = tmpUrl;
                }
                else
                {
                    //直接调用DoPost方法请求
                    // body = webUtils.DoPost(this.serverUrl, txtParams, this.charset);
                    //输出post表单
                    body = BuildHtmlRequest(txtParams, reqMethod, reqMethod);
                }
            }

            T rsp = null;
            IAopParser<T> parser = null;
            if ("xml".Equals(format))
            {
                parser = new AopXmlParser<T>();
                rsp = parser.Parse(body, charset);
            }
            else
            {
                parser = new AopJsonParser<T>();
                rsp = parser.Parse(body, charset);
            }

            //验签
            // CheckResponseSign(request, rsp, parser, this.alipayPublicKey, this.charset);
            return rsp;
        }

        #endregion

        #region SDK Execute

        public T SdkExecute<T>(IAopRequest<T> request) where T : AopResponse
        {
            // 构造请求参数
            var requestParams = BuildRequestParams(request, null, null);

            // 字典排序
            IDictionary<string, string> sortedParams = new SortedDictionary<string, string>(requestParams);
            var sortedAopDic = new AopDictionary(sortedParams);

            // 参数签名
            var charset = string.IsNullOrEmpty(this.charset) ? "utf-8" : this.charset;
            var signResult = AopUtils.SignAopRequest(sortedAopDic, privateKeyPem, charset, keyFromFile, signType);

            // 添加签名结果参数
            sortedAopDic.Add(SIGN, signResult);

            // 参数拼接
            var signedResult = WebUtils.BuildQuery(sortedAopDic, charset);

            // 构造结果
            var rsp = (T)Activator.CreateInstance(typeof(T));
            rsp.Body = signedResult;
            return rsp;
        }

        public async Task<T> SdkExecuteAsync<T>(IAopRequest<T> request) where T : AopResponse
        {
            // throw new NotImplementedException();
            await Task.Delay(100);
            // 构造请求参数
            var requestParams = BuildRequestParams(request, null, null);

            // 字典排序
            IDictionary<string, string> sortedParams = new SortedDictionary<string, string>(requestParams);
            var sortedAopDic = new AopDictionary(sortedParams);

            // 参数签名
            var charset = string.IsNullOrEmpty(this.charset) ? "utf-8" : this.charset;
            var signResult = AopUtils.SignAopRequest(sortedAopDic, privateKeyPem, charset, keyFromFile, signType);

            // 添加签名结果参数
            sortedAopDic.Add(SIGN, signResult);

            // 参数拼接
            var signedResult = WebUtils.BuildQuery(sortedAopDic, charset);

            // 构造结果
            var rsp = (T)Activator.CreateInstance(typeof(T));
            rsp.Body = signedResult;
            return rsp;
        }

        #endregion

        #region IAopClient Members

        public string BuildHtmlRequest(IDictionary<string, string> sParaTemp, string strMethod, string strButtonValue)
        {
            //待请求参数数组
            IDictionary<string, string> dicPara = new Dictionary<string, string>();
            dicPara = sParaTemp;

            var sbHtml = new StringBuilder();
            //sbHtml.Append("<head><meta http-equiv=\"Content-Type\" content=\"text/html\" charset= \"" + charset + "\" /></head>");

            sbHtml.Append("<form id='alipaysubmit' name='alipaysubmit' action='" + serverUrl + "?charset=" + charset +
                          "' method='" + strMethod + "'>");
            ;
            foreach (var temp in dicPara)
                sbHtml.Append("<input  name='" + temp.Key + "' value='" + temp.Value + "'/>");

            //submit按钮控件请不要含有name属性
            sbHtml.Append("<input type='submit' value='" + strButtonValue + "' style='display:none;'></form>");
            // sbHtml.Append("<input type='submit' value='" + strButtonValue + "'></form></div>");

            //表单实现自动提交
            sbHtml.Append("<script>document.forms['alipaysubmit'].submit();</script>");

            return sbHtml.ToString();
        }

        #endregion

        #region Common Method

        private AopDictionary BuildRequestParams<T>(IAopRequest<T> request, string accessToken, string appAuthToken)
            where T : AopResponse
        {
            // 默认参数
            var oriParams = new AopDictionary(request.GetParameters());

            // 序列化BizModel
            var result = SerializeBizModel(oriParams, request);

            // 获取参数
            var charset = string.IsNullOrEmpty(this.charset) ? "utf-8" : this.charset;
            var apiVersion = string.IsNullOrEmpty(request.GetApiVersion()) ? Version : request.GetApiVersion();

            // 添加协议级请求参数，为空的参数后面会自动过滤，这里不做处理。
            result.Add(METHOD, request.GetApiName());
            result.Add(VERSION, apiVersion);
            result.Add(APP_ID, AppId);
            result.Add(FORMAT, format);
            result.Add(TIMESTAMP, DateTime.Now);
            result.Add(ACCESS_TOKEN, accessToken);
            result.Add(SIGN_TYPE, signType);
            result.Add(TERMINAL_TYPE, request.GetTerminalType());
            result.Add(TERMINAL_INFO, request.GetTerminalInfo());
            result.Add(PROD_CODE, request.GetProdCode());
            result.Add(NOTIFY_URL, request.GetNotifyUrl());
            result.Add(CHARSET, charset);
            result.Add(RETURN_URL, request.GetReturnUrl());
            result.Add(APP_AUTH_TOKEN, appAuthToken);

            if (request.GetNeedEncrypt())
            {
                if (string.IsNullOrEmpty(result[BIZ_CONTENT]))
                    throw new AopException("api request Fail ! The reason: encrypt request is not supported!");

                if (string.IsNullOrEmpty(encyptKey) || string.IsNullOrEmpty(encyptType))
                    throw new AopException("encryptType or encryptKey must not null!");

                if (!"AES".Equals(encyptType))
                    throw new AopException("api only support Aes!");

                var encryptContent = AopUtils.AesEncrypt(encyptKey, result[BIZ_CONTENT], this.charset);
                result.Remove(BIZ_CONTENT);
                result.Add(BIZ_CONTENT, encryptContent);
                result.Add(ENCRYPT_TYPE, encyptType);
            }

            return result;
        }

        #endregion

        #region DefaultAopClient Constructors

        public DefaultAopClient(string serverUrl, string appId, string privateKeyPem)
        {
            AppId = appId;
            this.privateKeyPem = privateKeyPem;
            this.serverUrl = serverUrl;
            webUtils = new WebUtils();
        }

        public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, bool keyFromFile)
        {
            AppId = appId;
            this.privateKeyPem = privateKeyPem;
            this.serverUrl = serverUrl;
            this.keyFromFile = keyFromFile;
            webUtils = new WebUtils();
        }

        public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, string format)
        {
            AppId = appId;
            this.privateKeyPem = privateKeyPem;
            this.serverUrl = serverUrl;
            this.format = format;
            webUtils = new WebUtils();
        }

        public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, string format, string charset)
            : this(serverUrl, appId, privateKeyPem, format)
        {
            this.charset = charset;
        }

        public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, string format, string version,
            string signType)
            : this(serverUrl, appId, privateKeyPem)
        {
            this.format = format;
            this.version = version;
            this.signType = signType;
        }

        public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, string format, string version,
            string signType, string alipayPulicKey)
            : this(serverUrl, appId, privateKeyPem, format, version, signType)
        {
            alipayPublicKey = alipayPulicKey;
        }

        public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, string format, string version,
            string signType, string alipayPulicKey, string charset)
            : this(serverUrl, appId, privateKeyPem, format, version, signType, alipayPulicKey)
        {
            this.charset = charset;
        }

        //
        public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, string format, string version,
            string signType, string alipayPulicKey, string charset, bool keyFromFile)
            : this(serverUrl, appId, privateKeyPem, format, version, signType, alipayPulicKey)
        {
            this.keyFromFile = keyFromFile;
            this.charset = charset;
        }

        public DefaultAopClient(string serverUrl, string appId, string privateKeyPem, string format, string version,
            string signType, string alipayPulicKey, string charset, string encyptKey)
            : this(serverUrl, appId, privateKeyPem, format, version, signType, alipayPulicKey, charset)
        {
            this.encyptKey = encyptKey;
            encyptType = "AES";
        }


        public void SetTimeout(int timeout)
        {
            webUtils.Timeout = timeout;
        }

        #endregion

        #region IAopClient Members

        public T Execute<T>(IAopRequest<T> request) where T : AopResponse
        {
            return Execute(request, null);
        }

        public async Task<T> ExecuteAsync<T>(IAopRequest<T> request) where T : AopResponse
        {
            return await ExecuteAsync(request, null);
        }

        public T Execute<T>(IAopRequest<T> request, string accessToken) where T : AopResponse
        {
            return Execute(request, accessToken, null);
        }

        public async Task<T> ExecuteAsync<T>(IAopRequest<T> request, string accessToken) where T : AopResponse
        {
            return await ExecuteAsync(request, accessToken, null);
        }

        #endregion

        #region IAopClient Members

        public T Execute<T>(IAopRequest<T> request, string accessToken, string appAuthToken) where T : AopResponse
        {
            if (string.IsNullOrEmpty(charset))
                charset = "utf-8";

            string apiVersion = !string.IsNullOrEmpty(request.GetApiVersion()) ? request.GetApiVersion() : Version;

            // 添加协议级请求参数
            var txtParams = new AopDictionary(request.GetParameters());

            // 序列化BizModel
            txtParams = SerializeBizModel(txtParams, request);

            txtParams.Add(METHOD, request.GetApiName());
            txtParams.Add(VERSION, apiVersion);
            txtParams.Add(APP_ID, AppId);
            txtParams.Add(FORMAT, format);
            txtParams.Add(TIMESTAMP, DateTime.Now);
            txtParams.Add(ACCESS_TOKEN, accessToken);
            txtParams.Add(SIGN_TYPE, signType);
            txtParams.Add(TERMINAL_TYPE, request.GetTerminalType());
            txtParams.Add(TERMINAL_INFO, request.GetTerminalInfo());
            txtParams.Add(PROD_CODE, request.GetProdCode());
            txtParams.Add(CHARSET, charset);


            if (!string.IsNullOrEmpty(request.GetNotifyUrl()))
                txtParams.Add(NOTIFY_URL, request.GetNotifyUrl());

            if (!string.IsNullOrEmpty(appAuthToken))
                txtParams.Add(APP_AUTH_TOKEN, appAuthToken);


            if (request.GetNeedEncrypt())
            {
                if (string.IsNullOrEmpty(txtParams[BIZ_CONTENT]))
                    throw new AopException("api request Fail ! The reason: encrypt request is not supported!");

                if (string.IsNullOrEmpty(encyptKey) || string.IsNullOrEmpty(encyptType))
                    throw new AopException("encryptType or encryptKey must not null!");

                if (!"AES".Equals(encyptType))
                    throw new AopException("api only support Aes!");

                var encryptContent = AopUtils.AesEncrypt(encyptKey, txtParams[BIZ_CONTENT], charset);
                txtParams.Remove(BIZ_CONTENT);
                txtParams.Add(BIZ_CONTENT, encryptContent);
                txtParams.Add(ENCRYPT_TYPE, encyptType);
            }

            // 添加签名参数
            txtParams.Add(SIGN, AopUtils.SignAopRequest(txtParams, privateKeyPem, charset, keyFromFile, signType));


            // 是否需要上传文件
            string body;


            if (request is IAopUploadRequest<T> uRequest)
            {
                var fileParams = AopUtils.CleanupDictionary(uRequest.GetFileParameters());
                body = webUtils.DoPost(serverUrl + "?" + CHARSET + "=" + charset, txtParams, fileParams, charset);
            }
            else
            {
                body = webUtils.DoPost(serverUrl + "?" + CHARSET + "=" + charset, txtParams, charset);
            }

            T rsp = null;
            IAopParser<T> parser = null;
            if ("xml".Equals(format))
            {
                parser = new AopXmlParser<T>();
                rsp = parser.Parse(body, charset);
            }
            else
            {
                parser = new AopJsonParser<T>();
                rsp = parser.Parse(body, charset);
            }

            var item = ParseRespItem(request, body, parser, encyptKey, encyptType, charset);
            rsp = parser.Parse(item.realContent, charset);

            CheckResponseSign(request, item.respContent, rsp.IsError, parser, alipayPublicKey, charset, signType, keyFromFile);

            return rsp;
        }

        public async Task<T> ExecuteAsync<T>(IAopRequest<T> request, string accessToken, string appAuthToken) where T : AopResponse
        {
            if (string.IsNullOrEmpty(charset))
                charset = "utf-8";

            string apiVersion = !string.IsNullOrEmpty(request.GetApiVersion()) ? request.GetApiVersion() : Version;

            // 添加协议级请求参数
            var txtParams = new AopDictionary(request.GetParameters());

            // 序列化BizModel
            txtParams = SerializeBizModel(txtParams, request);

            txtParams.Add(METHOD, request.GetApiName());
            txtParams.Add(VERSION, apiVersion);
            txtParams.Add(APP_ID, AppId);
            txtParams.Add(FORMAT, format);
            txtParams.Add(TIMESTAMP, DateTime.Now);
            txtParams.Add(ACCESS_TOKEN, accessToken);
            txtParams.Add(SIGN_TYPE, signType);
            txtParams.Add(TERMINAL_TYPE, request.GetTerminalType());
            txtParams.Add(TERMINAL_INFO, request.GetTerminalInfo());
            txtParams.Add(PROD_CODE, request.GetProdCode());
            txtParams.Add(CHARSET, charset);


            if (!string.IsNullOrEmpty(request.GetNotifyUrl()))
                txtParams.Add(NOTIFY_URL, request.GetNotifyUrl());

            if (!string.IsNullOrEmpty(appAuthToken))
                txtParams.Add(APP_AUTH_TOKEN, appAuthToken);


            if (request.GetNeedEncrypt())
            {
                if (string.IsNullOrEmpty(txtParams[BIZ_CONTENT]))
                    throw new AopException("api request Fail ! The reason: encrypt request is not supported!");

                if (string.IsNullOrEmpty(encyptKey) || string.IsNullOrEmpty(encyptType))
                    throw new AopException("encryptType or encryptKey must not null!");

                if (!"AES".Equals(encyptType))
                    throw new AopException("api only support Aes!");

                var encryptContent = AopUtils.AesEncrypt(encyptKey, txtParams[BIZ_CONTENT], charset);
                txtParams.Remove(BIZ_CONTENT);
                txtParams.Add(BIZ_CONTENT, encryptContent);
                txtParams.Add(ENCRYPT_TYPE, encyptType);
            }

            // 添加签名参数
            txtParams.Add(SIGN, AopUtils.SignAopRequest(txtParams, privateKeyPem, charset, keyFromFile, signType));


            // 是否需要上传文件
            string body;


            if (request is IAopUploadRequest<T> uRequest)
            {
                var fileParams = AopUtils.CleanupDictionary(uRequest.GetFileParameters());
                body = await webUtils.DoPostAsync(serverUrl + "?" + CHARSET + "=" + charset, txtParams, fileParams, charset);
            }
            else
            {
                body = await webUtils.DoPostAsync(serverUrl + "?" + CHARSET + "=" + charset, txtParams, charset);
            }

            T rsp = null;
            IAopParser<T> parser = null;
            if ("xml".Equals(format))
            {
                parser = new AopXmlParser<T>();
                rsp = parser.Parse(body, charset);
            }
            else
            {
                parser = new AopJsonParser<T>();
                rsp = parser.Parse(body, charset);
            }

            var item = ParseRespItem(request, body, parser, encyptKey, encyptType, charset);
            rsp = parser.Parse(item.realContent, charset);

            CheckResponseSign(request, item.respContent, rsp.IsError, parser, alipayPublicKey, charset, signType, keyFromFile);

            return rsp;
        }


        private static ResponseParseItem ParseRespItem<T>(IAopRequest<T> request, string respBody, IAopParser<T> parser,
            string encryptKey, string encryptType, string charset) where T : AopResponse
        {
            string realContent = request.GetNeedEncrypt() ? parser.EncryptSourceData(request, respBody, encryptType, encryptKey, charset) : respBody;
            var item = new ResponseParseItem
            {
                realContent = realContent,
                respContent = respBody
            };

            return item;
        }

        public static void CheckResponseSign<T>(IAopRequest<T> request, string responseBody, bool isError,
            IAopParser<T> parser, string alipayPublicKey, string charset, string signType) where T : AopResponse
        {
            if (string.IsNullOrEmpty(alipayPublicKey) || string.IsNullOrEmpty(charset))
                return;

            var signItem = parser.GetSignItem(request, responseBody);
            if (signItem == null)
                throw new AopException("sign check fail: Body is Empty!");

            if (!isError ||
                isError && !string.IsNullOrEmpty(signItem.Sign))
            {
                var rsaCheckContent =
                    AlipaySignature.RSACheckContent(signItem.SignSourceDate, signItem.Sign, alipayPublicKey, charset, signType);
                if (!rsaCheckContent)
                    if (!string.IsNullOrEmpty(signItem.SignSourceDate) && signItem.SignSourceDate.Contains("\\/"))
                    {
                        var srouceData = signItem.SignSourceDate.Replace("\\/", "/");
                        var jsonCheck = AlipaySignature.RSACheckContent(srouceData, signItem.Sign, alipayPublicKey, charset, signType);
                        if (!jsonCheck)
                            throw new AopException(
                                "sign check fail: check Sign and Data Fail JSON also");
                    }
                    else
                    {
                        throw new AopException(
                            "sign check fail: check Sign and Data Fail!");
                    }
            }
        }

        public static void CheckResponseSign<T>(IAopRequest<T> request, string responseBody, bool isError,
            IAopParser<T> parser, string alipayPublicKey, string charset, string signType, bool keyFromFile)
            where T : AopResponse
        {
            if (string.IsNullOrEmpty(alipayPublicKey) || string.IsNullOrEmpty(charset))
                return;

            var signItem = parser.GetSignItem(request, responseBody);
            if (signItem == null)
                throw new AopException("sign check fail: Body is Empty!");

            if (!isError ||
                isError && !string.IsNullOrEmpty(signItem.Sign))
            {
                var rsaCheckContent = AlipaySignature.RSACheckContent(signItem.SignSourceDate, signItem.Sign, alipayPublicKey,
                    charset, signType, keyFromFile);
                if (!rsaCheckContent)
                    if (!string.IsNullOrEmpty(signItem.SignSourceDate) && signItem.SignSourceDate.Contains("\\/"))
                    {
                        var srouceData = signItem.SignSourceDate.Replace("\\/", "/");
                        var jsonCheck =
                            AlipaySignature.RSACheckContent(srouceData, signItem.Sign, alipayPublicKey, charset, signType, keyFromFile);
                        if (!jsonCheck)
                            throw new AopException(
                                "sign check fail: check Sign and Data Fail JSON also");
                    }
                    else
                    {
                        throw new AopException(
                            "sign check fail: check Sign and Data Fail!");
                    }
            }
        }

        #endregion

        #region IAopClient Members

        public Dictionary<string, string> FilterPara(SortedDictionary<string, string> dicArrayPre)
        {
            var dicArray = new Dictionary<string, string>();
            foreach (var temp in dicArrayPre)
                if (temp.Key.ToLower() != "sign" && temp.Key.ToLower() != "sign_type" && temp.Value != "" && temp.Value != null)
                    dicArray.Add(temp.Key, temp.Value);

            return dicArray;
        }

        public static string CreateLinkStringUrlencode(Dictionary<string, string> dicArray, Encoding code)
        {
            var prestr = new StringBuilder();
            foreach (var temp in dicArray)
                prestr.Append(temp.Key + "=" + HttpUtility.UrlEncode(temp.Value, code) + "&");

            //去掉最後一個&字符
            var nLen = prestr.Length;
            prestr.Remove(nLen - 1, 1);

            return prestr.ToString();
        }

        #endregion

        #region Model Serialize

        /// <summary>
        /// 序列化 业务模型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="requestParams"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        private AopDictionary SerializeBizModel<T>(AopDictionary requestParams, IAopRequest<T> request) where T : AopResponse
        {
            var result = requestParams;
            var isBizContentEmpty = !requestParams.ContainsKey(BIZ_CONTENT) || string.IsNullOrEmpty(requestParams[BIZ_CONTENT]);
            if (isBizContentEmpty && request.GetBizModel() != null)
            {
                var bizModel = request.GetBizModel();
                var content = Serialize(bizModel);
                result.Add(BIZ_CONTENT, content);
            }
            return result;
        }

        /// <summary>
        /// AopObject序列化
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private string Serialize(AopObject obj)
        {
            JsonSerializerSettings jsetting = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };
            return JsonConvert.SerializeObject(obj, Formatting.None, jsetting);
        }

        #endregion
    }
}