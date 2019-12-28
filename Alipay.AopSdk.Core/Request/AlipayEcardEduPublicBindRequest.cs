using System.Collections.Generic;
using Alipay.AopSdk.Core.Response;

namespace Alipay.AopSdk.Core.Request
{
	/// <summary>
	///     AOP API: alipay.ecard.edu.public.bind
	/// </summary>
	public class AlipayEcardEduPublicBindRequest : IAopRequest<AlipayEcardEduPublicBindResponse>
	{
		/// <summary>
		///     机构编码
		/// </summary>
		public string AgentCode { get; set; }

		/// <summary>
		///     公众账号协议Id
		/// </summary>
		public string AgreementId { get; set; }

		/// <summary>
		///     支付宝userId
		/// </summary>
		public string AlipayUserId { get; set; }

		/// <summary>
		///     一卡通姓名
		/// </summary>
		public string CardName { get; set; }

		/// <summary>
		///     一卡通卡号
		/// </summary>
		public string CardNo { get; set; }

		/// <summary>
		///     公众账号id
		/// </summary>
		public string PublicId { get; set; }

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
			return "alipay.ecard.edu.public.bind";
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
			parameters.Add("agent_code", AgentCode);
			parameters.Add("agreement_id", AgreementId);
			parameters.Add("alipay_user_id", AlipayUserId);
			parameters.Add("card_name", CardName);
			parameters.Add("card_no", CardNo);
			parameters.Add("public_id", PublicId);
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