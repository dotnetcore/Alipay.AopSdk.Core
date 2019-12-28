using System.Collections.Generic;
using Alipay.AopSdk.Core.Response;

namespace Alipay.AopSdk.Core.Request
{
	/// <summary>
	///     AOP API: alipay.ecapiprod.drawndn.drawndnlist.query
	/// </summary>
	public class
		AlipayEcapiprodDrawndnDrawndnlistQueryRequest : IAopRequest<AlipayEcapiprodDrawndnDrawndnlistQueryResponse>
	{
		/// <summary>
		///     授信编号
		/// </summary>
		public string CreditNo { get; set; }

		/// <summary>
		///     身份证号码
		/// </summary>
		public string EntityCode { get; set; }

		/// <summary>
		///     客户的姓名
		/// </summary>
		public string EntityName { get; set; }

		/// <summary>
		///     融资平台分配给ISV的编码
		/// </summary>
		public string IsvCode { get; set; }

		/// <summary>
		///     融资平台分配给小贷公司的机构编码
		/// </summary>
		public string OrgCode { get; set; }

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
			return "alipay.ecapiprod.drawndn.drawndnlist.query";
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
			parameters.Add("credit_no", CreditNo);
			parameters.Add("entity_code", EntityCode);
			parameters.Add("entity_name", EntityName);
			parameters.Add("isv_code", IsvCode);
			parameters.Add("org_code", OrgCode);
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