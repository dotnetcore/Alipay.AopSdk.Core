using System.Collections.Generic;
using Alipay.AopSdk.Core.Response;

namespace Alipay.AopSdk.Core.Request
{
	/// <summary>
	///     AOP API: alipay.ebpp.pdeduct.pay
	/// </summary>
	public class AlipayEbppPdeductPayRequest : IAopRequest<AlipayEbppPdeductPayResponse>
	{
		/// <summary>
		///     渠道码，如用户通过机构通过服务窗进来签约则是PUBLICFORM，此值可随意传，只要不空就行
		/// </summary>
		public string AgentChannel { get; set; }

		/// <summary>
		///     二级渠道码，预留字段
		/// </summary>
		public string AgentCode { get; set; }

		/// <summary>
		///     支付宝代扣协议Id
		/// </summary>
		public string AgreementId { get; set; }

		/// <summary>
		///     账期
		/// </summary>
		public string BillDate { get; set; }

		/// <summary>
		///     户号，缴费单位用于标识每一户的唯一性的
		/// </summary>
		public string BillKey { get; set; }

		/// <summary>
		///     扩展参数。必须以key value形式定义，  转为json为格式：{"key1":"value1","key2":"value2",  "key3":"value3","key4":"value4"}
		///     后端会直接转换为MAP对象，转换异常会报参数格式错误
		/// </summary>
		public string ExtendField { get; set; }

		/// <summary>
		///     滞纳金
		/// </summary>
		public string FineAmount { get; set; }

		/// <summary>
		///     备注信息
		/// </summary>
		public string Memo { get; set; }

		/// <summary>
		///     商户外部业务流水号
		/// </summary>
		public string OutOrderNo { get; set; }

		/// <summary>
		///     扣款金额，支付总金额，包含滞纳金
		/// </summary>
		public string PayAmount { get; set; }

		/// <summary>
		///     商户PartnerId
		/// </summary>
		public string Pid { get; set; }

		/// <summary>
		///     用户ID
		/// </summary>
		public string UserId { get; set; }

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
			return "alipay.ebpp.pdeduct.pay";
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
			parameters.Add("agent_channel", AgentChannel);
			parameters.Add("agent_code", AgentCode);
			parameters.Add("agreement_id", AgreementId);
			parameters.Add("bill_date", BillDate);
			parameters.Add("bill_key", BillKey);
			parameters.Add("extend_field", ExtendField);
			parameters.Add("fine_amount", FineAmount);
			parameters.Add("memo", Memo);
			parameters.Add("out_order_no", OutOrderNo);
			parameters.Add("pay_amount", PayAmount);
			parameters.Add("pid", Pid);
			parameters.Add("user_id", UserId);
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