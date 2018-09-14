using System;
using System.Collections.Generic;
using System.Net.Http;
using Alipay.AopSdk.Core;
using Alipay.AopSdk.Core.Util;
using Alipay.AopSdk.F2FPay.Business;
using Alipay.AopSdk.F2FPay.Domain;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace Alipay.AopSdk.AspnetCore
{
	public class AlipayService
	{
		public AlipayOptions Options { get; set; }

		private readonly IAopClient _aopClient;
		public AlipayService(IOptions<AlipayOptions> alipayOptions)
		{
			Options = alipayOptions.Value;
			_aopClient = new DefaultAopClient(Options.Gatewayurl, Options.AppId, Options.PrivateKey, "json", "1.0",
				Options.SignType, Options.AlipayPublicKey, Options.CharSet, Options.IsKeyFromFile);
		}
		public T Execute<T>(IAopRequest<T> request) where T : AopResponse
		{
			return _aopClient.Execute(request);
		}

		public T Execute<T>(IAopRequest<T> request, string session) where T : AopResponse
		{
			return _aopClient.Execute(request, session);
		}

		public T Execute<T>(IAopRequest<T> request, string session, string appAuthToken) where T : AopResponse
		{
			return _aopClient.Execute(request, session,appAuthToken);
		}

		public T pageExecute<T>(IAopRequest<T> request) where T : AopResponse
		{
			return _aopClient.pageExecute(request);
		}

		public T pageExecute<T>(IAopRequest<T> request, string session, string reqMethod) where T : AopResponse
		{
			return _aopClient.pageExecute(request,session,reqMethod);
		}

		public T SdkExecute<T>(IAopRequest<T> request) where T : AopResponse
		{
			return _aopClient.SdkExecute(request);
		}

		public bool RSACheckV1(Dictionary<string, string> data)
		{
			return AlipaySignature.RSACheckV1(data, Options.AlipayPublicKey, Options.CharSet, Options.SignType, false);
		}

	    
    }
}