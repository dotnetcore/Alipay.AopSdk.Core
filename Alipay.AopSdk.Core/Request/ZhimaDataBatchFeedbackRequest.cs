using System.Collections.Generic;
using Alipay.AopSdk.Core;
using Alipay.AopSdk.Core.Response;
using Alipay.AopSdk.Core.Util;

namespace Alipay.AopSdk.Core.Request
{
	/// <summary>
	///     AOP API: zhima.data.batch.feedback
	/// </summary>
	public class ZhimaDataBatchFeedbackRequest : IAopUploadRequest<ZhimaDataBatchFeedbackResponse>
	{
		/// <summary>
		///     扩展参数
		/// </summary>
		public string BizExtParams { get; set; }

		/// <summary>
		///     单条数据的数据列，多个列以逗号隔开
		/// </summary>
		public string Columns { get; set; }

		/// <summary>
		///     反馈的json格式文件，其中{"records":  是每个文件的固定开头，文件中的字段名请使用数据反馈模板（该模板是通过“获取数据反馈模板”接口获得）中字段编码列的英文字段来组装
		/// </summary>
		public FileItem File { get; set; }

		/// <summary>
		///     是反馈文件的数据编码，如果文件格式是UTF-8，则填写UTF-8，如果文件格式是GBK，则填写GBK
		/// </summary>
		public string FileCharset { get; set; }

		/// <summary>
		///     文件描述信息
		/// </summary>
		public string FileDescription { get; set; }

		/// <summary>
		///     反馈的数据类型
		/// </summary>
		public string FileType { get; set; }

		/// <summary>
		///     主键列使用反馈字段进行组合，也可以使用反馈的某个单字段（确保主键稳定，而且可以很好的区分不同的数据）。例如order_no,pay_month或者order_no,bill_month组合，对于一个order_no只会有一条数据的情况，直接使用order_no作为主键列
		/// </summary>
		public string PrimaryKeyColumns { get; set; }

		/// <summary>
		///     文件数据记录条数
		/// </summary>
		public string Records { get; set; }

		#region IAopUploadRequest Members

		public IDictionary<string, FileItem> GetFileParameters()
		{
			IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
			parameters.Add("file", File);
			return parameters;
		}

		#endregion

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

		public void SetApiVersion(string apiVersion)
		{
			this.apiVersion = apiVersion;
		}

		public string GetApiVersion()
		{
			return apiVersion;
		}

		public string GetApiName()
		{
			return "zhima.data.batch.feedback";
		}

		public IDictionary<string, string> GetParameters()
		{
			var parameters = new AopDictionary();
			parameters.Add("biz_ext_params", BizExtParams);
			parameters.Add("columns", Columns);
			parameters.Add("file_charset", FileCharset);
			parameters.Add("file_description", FileDescription);
			parameters.Add("file_type", FileType);
			parameters.Add("primary_key_columns", PrimaryKeyColumns);
			parameters.Add("records", Records);
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