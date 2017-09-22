using System;
using System.Collections.Generic;
using Alipay.AopSdk.Core.Response;

namespace Alipay.AopSdk.Core.Request
{
	/// <summary>
	///     AOP API: alipay.point.order.add
	/// </summary>
	public class AlipayPointOrderAddRequest : IAopRequest<AlipayPointOrderAddResponse>
	{
		/// <summary>
		///     向用户展示集分宝发放备注
		/// </summary>
		public string Memo { get; set; }

		/// <summary>
		///     isv提供的发放订单号，由数字和字母组成，最大长度为32位，需要保证每笔订单发放的唯一性，支付宝对该参数做唯一性校验。如果订单号已存在，支付宝将返回订单号已经存在的错误
		/// </summary>
		public string MerchantOrderNo { get; set; }

		/// <summary>
		///     发放集分宝时间
		/// </summary>
		public DateTime? OrderTime { get; set; }

		/// <summary>
		///     发放集分宝的数量
		/// </summary>
		public long? PointCount { get; set; }

		/// <summary>
		///     用户标识符，用于指定集分宝发放的用户，和user_symbol_type一起使用，确定一个唯一的支付宝用户
		/// </summary>
		public string UserSymbol { get; set; }

		/// <summary>
		///     用户标识符类型，现在支持ALIPAY_USER_ID:表示支付宝用户ID,ALIPAY_LOGON_ID:表示支付宝登陆号
		/// </summary>
		public string UserSymbolType { get; set; }

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
			return "alipay.point.order.add";
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
			parameters.Add("memo", Memo);
			parameters.Add("merchant_order_no", MerchantOrderNo);
			parameters.Add("order_time", OrderTime);
			parameters.Add("point_count", PointCount);
			parameters.Add("user_symbol", UserSymbol);
			parameters.Add("user_symbol_type", UserSymbolType);
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