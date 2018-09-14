using System;
using Alipay.AopSdk.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Alipay.AopSdk.AspnetCore
{
	/// <summary>
	/// 支付宝 支付服务
	/// </summary>
	public static class AlipayServiceCollectionExtensions
	{
		public static IServiceCollection AddAlipay(this IServiceCollection services,Action<AlipayOptions> options)
		{
			if (services == null)
				throw new ArgumentNullException(nameof(services));

			if (options == null)
				throw new ArgumentNullException(nameof(options));
			services.AddOptions();
			services.Configure(options);
            services.AddScoped<AlipayService>();
			return services;
		}

	    public static IServiceCollection AddAlipay(this IServiceCollection services, IConfiguration section)
	    {
	        if (services == null)
	            throw new ArgumentNullException(nameof(services));
	        services.AddOptions();
            services.Configure<AlipayOptions>(section);
	        services.AddScoped<AlipayService>();
	        return services;
	    }
    }
}