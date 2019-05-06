using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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
            services.AddSingleton<AlipayService>();
		    services.AddSingleton<AlipayF2FService>();
            return services;
		}

	    public static IServiceCollection AddAlipay(this IServiceCollection services, IConfiguration section)
	    {
	        if (services == null)
	            throw new ArgumentNullException(nameof(services));
	        if (section == null)
	            throw new ArgumentNullException(nameof(section));
            services.AddOptions();
            services.Configure<AlipayOptions>(section);
	        services.AddSingleton<AlipayService>();
	        services.AddSingleton<AlipayF2FService>();
	        return services;
	    }
    }
}