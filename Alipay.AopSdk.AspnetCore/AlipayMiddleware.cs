using System;
using System.Globalization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Alipay.AopSdk.AspnetCore
{
	/// <summary>
	/// 支付宝支付 中间件
	/// 作者：李志强
	/// 时间：2017年10月31日
	/// </summary>
    public class AlipayMiddleware
	{
		private readonly RequestDelegate _next;

		public AlipayMiddleware(RequestDelegate next)
		{
			_next = next;
		}

		public Task Invoke(HttpContext context)
		{
			return this._next(context);
		}
	}
}
