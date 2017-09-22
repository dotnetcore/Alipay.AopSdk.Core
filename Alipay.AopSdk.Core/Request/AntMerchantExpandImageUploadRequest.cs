using System.Collections.Generic;
using Alipay.AopSdk.Core;
using Alipay.AopSdk.Core.Response;
using Alipay.AopSdk.Core.Util;

namespace Alipay.AopSdk.Core.Request
{
	/// <summary>
	///     AOP API: ant.merchant.expand.image.upload
	/// </summary>
	public class AntMerchantExpandImageUploadRequest : IAopUploadRequest<AntMerchantExpandImageUploadResponse>
	{
		/// <summary>
		///     图片二进制字节流
		/// </summary>
		public FileItem ImageContent { get; set; }

		/// <summary>
		///     图片格式
		/// </summary>
		public string ImageType { get; set; }

		#region IAopUploadRequest Members

		public IDictionary<string, FileItem> GetFileParameters()
		{
			IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
			parameters.Add("image_content", ImageContent);
			return parameters;
		}

		#endregion

		#region IAopRequest Members

		private bool needEncrypt;
		private string apiVersion = "1.0";
		private string terminalType;
		private string terminalInfo;
		private string prodCode;
		private string notifyUrl;
		private string returnUrl;
		private AopObject bizModel;

		public void SetNeedEncrypt(bool needEncrypt)
		{
			this.needEncrypt = needEncrypt;
		}

		public bool GetNeedEncrypt()
		{
			return needEncrypt;
		}

		public void SetNotifyUrl(string notifyUrl)
		{
			this.notifyUrl = notifyUrl;
		}

		public string GetNotifyUrl()
		{
			return notifyUrl;
		}

		public void SetReturnUrl(string returnUrl)
		{
			this.returnUrl = returnUrl;
		}

		public string GetReturnUrl()
		{
			return returnUrl;
		}

		public void SetTerminalType(string terminalType)
		{
			this.terminalType = terminalType;
		}

		public string GetTerminalType()
		{
			return terminalType;
		}

		public void SetTerminalInfo(string terminalInfo)
		{
			this.terminalInfo = terminalInfo;
		}

		public string GetTerminalInfo()
		{
			return terminalInfo;
		}

		public void SetProdCode(string prodCode)
		{
			this.prodCode = prodCode;
		}

		public string GetProdCode()
		{
			return prodCode;
		}

		public void SetApiVersion(string apiVersion)
		{
			this.apiVersion = apiVersion;
		}

		public string GetApiVersion()
		{
			return apiVersion;
		}

		public string GetApiName()
		{
			return "ant.merchant.expand.image.upload";
		}

		public IDictionary<string, string> GetParameters()
		{
			var parameters = new AopDictionary();
			parameters.Add("image_type", ImageType);
			return parameters;
		}

		public AopObject GetBizModel()
		{
			return bizModel;
		}

		public void SetBizModel(AopObject bizModel)
		{
			this.bizModel = bizModel;
		}

		#endregion
	}
}