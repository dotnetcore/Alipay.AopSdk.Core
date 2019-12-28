using System.Collections.Generic;
using Alipay.AopSdk.Core.Response;

namespace Alipay.AopSdk.Core.Request
{
	/// <summary>
	///     AOP API: alipay.ecapiprod.data.put
	/// </summary>
	public class AlipayEcapiprodDataPutRequest : IAopRequest<AlipayEcapiprodDataPutResponse>
	{
		/// <summary>
		///     数据类型
		/// </summary>
		public string Category { get; set; }

		/// <summary>
		///     数据字符编码，默认UTF-8
		/// </summary>
		public string CharSet { get; set; }

		/// <summary>
		///     数据采集平台生成的采集任务编号
		/// </summary>
		public string CollectingTaskId { get; set; }

		/// <summary>
		///     身份证，工商注册号等
		/// </summary>
		public string EntityCode { get; set; }

		/// <summary>
		///     姓名或公司名等，name和code不能同时为空
		/// </summary>
		public string EntityName { get; set; }

		/// <summary>
		///     人或公司等
		/// </summary>
		public string EntityType { get; set; }

		/// <summary>
		///     渠道商
		/// </summary>
		public string IsvCode { get; set; }

		/// <summary>
		///     数据主体,以json格式传输的数据
		/// </summary>
		public string JsonData { get; set; }

		/// <summary>
		///     数据合作方
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
			return "alipay.ecapiprod.data.put";
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
			parameters.Add("category", Category);
			parameters.Add("char_set", CharSet);
			parameters.Add("collecting_task_id", CollectingTaskId);
			parameters.Add("entity_code", EntityCode);
			parameters.Add("entity_name", EntityName);
			parameters.Add("entity_type", EntityType);
			parameters.Add("isv_code", IsvCode);
			parameters.Add("json_data", JsonData);
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