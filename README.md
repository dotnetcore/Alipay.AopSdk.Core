[![Member project of .NET Core Community](https://img.shields.io/badge/member%20project%20of-NCC-9e20c9.svg?style=flat-square)](https://github.com/dotnetcore)

>说明：Alipay.AopSdk.Core 源起于 .NET Core 1.1 时期，当时的社区生态还不完善，很多组件都还没有迁移到 .NET Core ,当时有整好碰巧对接支付宝支付，所以基于支付宝官方的 Framework 的源码进行改造，进而诞生了 Alipay.AopSdk.Core，但随着时间的推移，支付宝业务的新增和变更，Alipay.AopSdk.Core 的更新速度远远比不上，而且官方也重构了 .NET SDK ，且配合官方文档以及代码生成器，现在使用十分方便，Alipay.AopSdk.Core 是时候退出舞台了。2020.9.16

# Alipay.AopSdk.Core

## 一.各个组件说明

组件名  | 说明 | 版本号 
-------- | :------------  | :------------ 
Alipay.AopSdk.Core | ASP.NET 项目可以单独安装此组件。服务端SDK，封装了支付宝开放平台的所有API  |  [![Latest version](https://img.shields.io/nuget/v/Alipay.AopSdk.Core.svg)](https://www.nuget.org/packages/Alipay.AopSdk.Core/)|
Alipay.AopSdk.AspnetCore  |  ASP.NET Core 项目可以单独安装此组件。服务端SDK的ASP.NET Core组件，为了能更好配合ASP.NET Core 使用  | [![Latest version](https://img.shields.io/nuget/v/Alipay.AopSdk.AspnetCore.svg)](https://www.nuget.org/packages/Alipay.AopSdk.AspnetCore/) |

>Alipay.AopSdk.F2FPay.AspnetCore、Alipay.AopSdk.F2FPay 在2.3版本已被合并。

支付宝（Alipay）服务端SDK，采用.NET Standard 2.0，支持.NET Core >= 2.0，与官方SDK接口完全相同。完全可以按照官方文档进行开发。除了支持支付以外，官方SDK支持的功能本SDK全部支持，且用法几乎一样，代码都可参考官方文档代码。。由于精力有限，所以只做了几个Demo，但是其他功能可以参照官方的Demo来使用。可以使用官方文档中的示例代码。如有问题请加QQ群4656606。
>本项目代码基于官方.NET Framework 代码重构而来以及加入了ASP.NET Core的扩展支持。

## 二.ASP.NET Core 使用

### 1.安装程序包

````
Install-Package Install-Package Alipay.AopSdk.AspnetCore
````

### 2.添加配置
````csharp
public void ConfigureServices(IServiceCollection services)
{
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
}
````

### 3.在Controller中使用

````csharp
//通过di注入
private readonly AlipayService  _alipayService;

public xxxController(AlipayService alipayService)
{
	_alipayService = alipayService;

}

_alipayService.Execute();
````

## 三.使用当面付（条码支付/扫描支付）


````csharp
private readonly AlipayF2FService _alipayF2FService;

public xxxController(AlipayF2FService alipayF2FService)
{
	_alipayF2FService = alipayF2FService;

}

_alipayF2FService.Execute();
````

## 四.配置

### 1.快捷添加配置的方法

在`appsettings.json`里添加如下信息

````json
 "Alipay": {
    "AlipayPublicKey": "",
    "AppId": "",
    "CharSet": "UTF-8",
    "Gatewayurl": "https://openapi.alipaydev.com/gateway.do",
    "PrivateKey": "",
    "SignType": "RSA2",
    "Uid": ""
  }
````

添加配置代码可改为如下：


````csharp
public void ConfigureServices(IServiceCollection services)
{
    services.AddAlipay(Configuration.GetSection("Alipay"));
    
}
````

### 2.密钥生成的方法

解压tool文件夹下`keygen.zip`压缩包，运行`start.bat`即可在keys目录下生成公钥和私钥，长度为2048。

这里生成的公钥和私钥，只需将**私钥**配置到配置文件文件中，公钥需要设置到支付宝后台。然后设置`SignType`为`RSA2`。配置文件中的公钥配置，不是我们自己生成的这个，需要到支付宝后台获取，这里需要注意一下。

![1526457521967](tool/assets/1526457521967.png)


## 五.文档信息

官方文档：

- [支付宝开放平台文档](https://docs.open.alipay.com/54/103419 "支付宝开放平台文档")

### 1.演示Demo

>实现支付、支付同步回调、支付异步通知、订单查询、退款、退款查询、订单关闭、扫码支付功能

- [PC网站支付Demo](https://github.com/stulzq/Alipay.Demo.PCPayment "PC网站支付Demo")

- [扫码支付Demo](https://github.com/stulzq/Alipay.Demo.PCPayment "扫码支付Demo")

- [PC获取支付宝会员信息（网站使用支付宝登录）](http://www.cnblogs.com/liulun/p/8410870.html "PC获取支付宝会员信息（网站使用支付宝登录）")


### 2.教程

- [ASP.NET Core 2.0 使用支付宝PC网站支付](http://www.cnblogs.com/stulzq/p/7606164.html "ASP.NET Core 2.0 使用支付宝PC网站支付")

- [ASP.NET Core 2.0 支付宝当面付之扫码支付](http://www.cnblogs.com/stulzq/p/7647948.html "ASP.NET Core 2.0 支付宝当面付之扫码支付")

### 3.使用问题集锦

[常见问题解答](http://www.cnblogs.com/stulzq/p/7873909.html)

