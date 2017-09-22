using System;
using System.Collections.Generic;
using Alipay.AopSdk.Core.Response;

namespace Alipay.AopSdk.Core.Request
{
	/// <summary>
	///     AOP API: alipay.mobile.code.create
	/// </summary>
	public class AlipayMobileCodeCreateRequest : IAopRequest<AlipayMobileCodeCreateResponse>
	{
		/// <summary>
		///     业务关联ID。比如订单号,userId，业务连接等
		/// </summary>
		public string BizLinkedId { get; set; }

		/// <summary>
		///     类似产品名称，根据该值决定码存储类型；新接业务需要找码平台技术配置
		/// </summary>
		public string BizType { get; set; }

		/// <summary>
		///     业务自定义,码平台不用理解。一定要传json字符串。
		/// </summary>
		public string ContextStr { get; set; }

		/// <summary>
		///     如果是true，则扫一扫下发跳转地址直接取自bizLinkedId  否则，从路由信息里取跳转地址
		/// </summary>
		public bool? IsDirect { get; set; }

		/// <summary>
		///     备注信息字段
		/// </summary>
		public string Memo { get; set; }

		/// <summary>
		///     发码来源，业务自定
		/// </summary>
		public string SourceId { get; set; }

		/// <summary>
		///     编码启动时间（yyy-MM-dd hh:mm:ss），为空表示立即启用
		/// </summary>
		public DateTime? StartDate { get; set; }

		/// <summary>
		///     超时时间,单位秒；若不传则为永久。发码超时时间需要找码平台技术评估
		/// </summary>
		public long? Timeout { get; set; }

		/// <summary>
		///     支付宝用户id
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
			return "alipay.mobile.code.create";
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
			parameters.Add("biz_linked_id", BizLinkedId);
			parameters.Add("biz_type", BizType);
			parameters.Add("context_str", ContextStr);
			parameters.Add("is_direct", IsDirect);
			parameters.Add("memo", Memo);
			parameters.Add("source_id", SourceId);
			parameters.Add("start_date", StartDate);
			parameters.Add("timeout", Timeout);
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