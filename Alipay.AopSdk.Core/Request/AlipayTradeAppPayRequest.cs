using System;
using System.Collections.Generic;
using Alipay.AopSdk.Core.Domain;
using Alipay.AopSdk.Core.Response;

namespace Alipay.AopSdk.Core.Request
{
	/// <summary>
	///     AOP API: alipay.trade.app.pay
	/// </summary>
	public class AlipayTradeAppPayRequest : IAopRequest<AlipayTradeAppPayResponse>
	{
		/// <summary>
		///     app支付接口2.0
		/// </summary>
		public string BizContent { get; set; }

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
			return "alipay.trade.app.pay";
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
			parameters.Add("biz_content", BizContent);
			return parameters;
		}

		public AopObject GetBizModel()
		{
			return bizModel;
		}

		public void SetBizModel(AopObject paramModel)
		{
			if (!(paramModel is AlipayTradeAppPayModel model))
			{
				throw new Exception("传入Model类型错误，应为 AlipayTradeAppPayModel");
			}
			else
			{
				if (decimal.TryParse(model.TotalAmount, out var result))
				{
					if (model.TotalAmount.Contains("."))
					{
						var temp = model.TotalAmount.Split('.');
						if (temp[1].Length > 2)
						{
							throw new ArgumentException("参数值不正确，小数位数不得大于两位", nameof(model.TotalAmount));
						}
					}
				}
				else
				{
					throw new ArgumentException("参数值不正确", nameof(model.TotalAmount));
				}
			}


			this.bizModel = paramModel;
		}

		#endregion
	}
}