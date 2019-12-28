using System.Collections.Generic;
using Alipay.AopSdk.Core.Response;

namespace Alipay.AopSdk.Core.Request
{
	/// <summary>
	///     AOP API: alipay.user.account.search
	/// </summary>
	public class AlipayUserAccountSearchRequest : IAopRequest<AlipayUserAccountSearchResponse>
	{
		/// <summary>
		///     查询的结束时间
		/// </summary>
		public string EndTime { get; set; }

		/// <summary>
		///     需要过滤的字符
		/// </summary>
		public string Fields { get; set; }

		/// <summary>
		///     查询的页数
		/// </summary>
		public string PageNo { get; set; }

		/// <summary>
		///     每页的条数
		/// </summary>
		public string PageSize { get; set; }

		/// <summary>
		///     查询的开始时间
		/// </summary>
		public string StartTime { get; set; }

		/// <summary>
		///     查询账务的类型
		/// </summary>
		public string Type { get; set; }

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

		public string GetApiName()
		{
			return "alipay.user.account.search";
		}

		public void SetApiVersion(string apiVersion)
		{
			this.apiVersion = apiVersion;
		}

		public string GetApiVersion()
		{
			return apiVersion;
		}

		public IDictionary<string, string> GetParameters()
		{
			var parameters = new AopDictionary();
			parameters.Add("end_time", EndTime);
			parameters.Add("fields", Fields);
			parameters.Add("page_no", PageNo);
			parameters.Add("page_size", PageSize);
			parameters.Add("start_time", StartTime);
			parameters.Add("type", Type);
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