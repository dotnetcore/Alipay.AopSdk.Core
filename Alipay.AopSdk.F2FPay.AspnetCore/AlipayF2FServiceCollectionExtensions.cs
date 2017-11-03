using System;
using Alipay.AopSdk.AspnetCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Alipay.AopSdk.F2FPay.AspnetCore
{
    public static class AlipayF2FServiceCollectionExtensions
	{
		public static IServiceCollection AddAlipayF2F(this IServiceCollection services)
		{
			if (services == null)
				throw new ArgumentNullException(nameof(services));
			services.Add(ServiceDescriptor.Transient<IAlipayF2FService, AlipayF2FService>());
			return services;
		}
	}
}
