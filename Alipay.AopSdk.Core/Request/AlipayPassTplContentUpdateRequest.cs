using System.Collections.Generic;
using Alipay.AopSdk.Core.Response;

namespace Alipay.AopSdk.Core.Request
{
	/// <summary>
	///     AOP API: alipay.pass.tpl.content.update
	/// </summary>
	public class AlipayPassTplContentUpdateRequest : IAopRequest<AlipayPassTplContentUpdateResponse>
	{
		/// <summary>
		///     代理商代替商户发放卡券后，再代替商户更新卡券时，此值为商户的pid/appid
		/// </summary>
		public string ChannelId { get; set; }

		/// <summary>
		///     支付宝pass唯一标识
		/// </summary>
		public string SerialNumber { get; set; }

		/// <summary>
		///     券状态,支持更新为USED,CLOSED两种状态
		/// </summary>
		public string Status { get; set; }

		/// <summary>
		///     模版动态参数信息【支付宝pass模版参数键值对JSON字符串】
		/// </summary>
		public string TplParams { get; set; }

		/// <summary>
		///     核销码串值【当状态变更为USED时，建议传入】
		/// </summary>
		public string VerifyCode { get; set; }

		/// <summary>
		///     核销方式，目前支持：wave（声波方式）、qrcode（二维码方式）、barcode（条码方式）、input（文本方式，即手工输入方式）。pass和verify_type不能同时为空
		/// </summary>
		public string VerifyType { get; set; }

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
			return "alipay.pass.tpl.content.update";
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
			parameters.Add("channel_id", ChannelId);
			parameters.Add("serial_number", SerialNumber);
			parameters.Add("status", Status);
			parameters.Add("tpl_params", TplParams);
			parameters.Add("verify_code", VerifyCode);
			parameters.Add("verify_type", VerifyType);
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