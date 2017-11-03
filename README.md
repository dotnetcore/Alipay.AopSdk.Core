# Alipay.AopSdk.Core

![](https://www.alipay.com/favicon.ico)

组件名  | 说明 | 版本号 
-------- | :------------  | :------------ 
Alipay.AopSdk.Core | 服务端SDK，封装了支付宝开放平台的所有API  |  [![Latest version](https://img.shields.io/nuget/v/Alipay.AopSdk.Core.svg)](https://www.nuget.org/packages/Alipay.AopSdk.Core/)
Alipay.AopSdk.F2FPay  | 当面付SDK，提供条码支付、扫码支付能力  | [![Latest version](https://img.shields.io/nuget/v/Alipay.AopSdk.F2FPay.svg)](https://www.nuget.org/packages/Alipay.AopSdk.F2FPay/) 
Alipay.AopSdk.AspnetCore  | 服务端SDK的ASP.NET Core组件，为了能更好配合ASP.NET Core 使用  | [![Latest version](https://img.shields.io/nuget/v/Alipay.AopSdk.AspnetCore.svg)](https://www.nuget.org/packages/Alipay.AopSdk.AspnetCore/) 
Alipay.AopSdk.F2FPay.AspnetCore  | 当面付SDK的ASP.NET Core组件，为了能更好配合ASP.NET Core 使用  | [![Latest version](https://img.shields.io/nuget/v/Alipay.AopSdk.F2FPay.AspnetCore.svg)](https://www.nuget.org/packages/Alipay.AopSdk.F2FPay.AspnetCore/) 


支付宝（Alipay）服务端SDK AopSdk，修改自官方最新版本：113。采用.NET Standard 2.0，支持.NET Core 2.0，与官方SDK接口完全相同。完全可以按照官方文档进行开发。不仅仅支持支付，官方SDK支持的功能本SDK全部支持，用法几乎一样。由于精力有限，所以只做了几个Demo，但是其他功能可以参照官方的Demo来使用。可以使用官方文档中的示例代码。如有问题请联系QQ501232752

# ASP.NET Core

### Alipay.AopSdk.AspnetCore

````csharp
services.AddAlipay(options =>
	        {
		        options.AlipayPublicKey = "支付宝公钥";
		        options.AppId = "应用ID";
		        options.CharSet = "密钥编码";
		        options.Gatewayurl = "支付网关";
		        options.PrivateKey = "商家私钥";
		        options.SignType = "签名方式 RSA/RSA2";
		        options.Uid = "商户ID";
	        });
````
使用：

````csharp
private readonly IAlipayService  _alipayService;

public xxxController(IAlipayService alipayService)
{
	_alipayService = alipayService;

}

_alipayService.Execute();
````

### Alipay.AopSdk.F2FPay.AspnetCore

````csharp
services.AddAlipay(options =>
	        {
		        options.AlipayPublicKey = "支付宝公钥";
		        options.AppId = "应用ID";
		        options.CharSet = "密钥编码";
		        options.Gatewayurl = "支付网关";
		        options.PrivateKey = "商家私钥";
		        options.SignType = "签名方式 RSA/RSA2";
		        options.Uid = "商户ID";
	        }).AddAlipayF2F();;
````
使用：

````csharp
private readonly IAlipayF2FService _alipayF2FService;

public xxxController(IAlipayF2FService alipayF2FService)
{
	_alipayF2FService = alipayF2FService;

}

_alipayF2FService.Execute();
````

具体用法可以看Demo

更新日志：

- 2017-11-3 添加对ASP.NET Core的支持

- 2017-10-30 修复在Linux上的BUG

官方文档：

- [支付宝开放平台文档](https://docs.open.alipay.com/54/103419 "支付宝开放平台文档")

# Demo

- [PC网站支付Demo](https://github.com/stulzq/Alipay.Demo.PCPayment "PC网站支付Demo")

- [扫码支付Demo](https://github.com/stulzq/Alipay.Demo.PCPayment "扫码支付Demo")

- 更新中...

# Doc

- [ASP.NET Core 2.0 使用支付宝PC网站支付](http://www.cnblogs.com/stulzq/p/7606164.html "ASP.NET Core 2.0 使用支付宝PC网站支付")

- [ASP.NET Core 2.0 支付宝当面付之扫码支付](http://www.cnblogs.com/stulzq/p/7647948.html "ASP.NET Core 2.0 支付宝当面付之扫码支付")

- 更新中...
