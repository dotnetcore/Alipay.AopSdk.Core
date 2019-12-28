using System.Collections.Generic;
using Alipay.AopSdk.Core.Response;

namespace Alipay.AopSdk.Core.Request
{
	/// <summary>
	///     AOP API: alipay.mobile.public.account.reset
	/// </summary>
	public class AlipayMobilePublicAccountResetRequest : IAopRequest<AlipayMobilePublicAccountResetResponse>
	{
		/// <summary>
		///     协议号
		/// </summary>
		public string AgreementId { get; set; }

		/// <summary>
		///     绑定账户
		/// </summary>
		public string BindAccountNo { get; set; }

		/// <summary>
		///     json
		/// </summary>
		public string BizContent { get; set; }

		/// <summary>
		///     绑定账户的名
		/// </summary>
		public string DisplayName { get; set; }

		/// <summary>
		///     关注者标识
		/// </summary>
		public string FromUserId { get; set; }

		/// <summary>
		///     绑定账户的用户名
		/// </summary>
		public string RealName { get; set; }

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
			return "alipay.mobile.public.account.reset";
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
			parameters.Add("agreement_id", AgreementId);
			parameters.Add("bind_account_no", BindAccountNo);
			parameters.Add("biz_content", BizContent);
			parameters.Add("display_name", DisplayName);
			parameters.Add("from_user_id", FromUserId);
			parameters.Add("real_name", RealName);
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