using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core
{
	[Serializable]
	public abstract class AopResponse
	{
		private string body;
		private string code;
		private string msg;
		private string subCode;
		private string subMsg;

		/// <summary>
		///     错误码
		///     对应 ErrCode
		/// </summary>
		[JsonProperty("code")]
		public string Code
		{
			get => code;
			set => code = value;
		}

		/// <summary>
		///     错误信息
		///     对应 ErrMsg
		/// </summary>
		[JsonProperty("msg")]
		public string Msg
		{
			get => msg;
			set => msg = value;
		}

		/// <summary>
		///     子错误码
		///     对应 SubErrCode
		/// </summary>
		[JsonProperty("sub_code")]
		public string SubCode
		{
			get => subCode;
			set => subCode = value;
		}

		/// <summary>
		///     子错误信息
		///     对应 SubErrMsg
		/// </summary>
		[JsonProperty("sub_msg")]
		public string SubMsg
		{
			get => subMsg;
			set => subMsg = value;
		}

		/// <summary>
		///     响应原始内容
		/// </summary>
		public string Body
		{
			get => body;
			set => body = value;
		}

		/// <summary>
		///     响应结果是否错误
		/// </summary>
		public bool IsError => !string.IsNullOrEmpty(SubCode);
	}
}