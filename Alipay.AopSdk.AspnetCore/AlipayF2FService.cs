using Alipay.AopSdk.F2FPay.Business;
using Alipay.AopSdk.F2FPay.Domain;
using Microsoft.Extensions.Options;

namespace Alipay.AopSdk.AspnetCore
{
    public class AlipayF2FService
    {
        public AlipayOptions Options { get; set; }

        private readonly IAlipayTradeService _alipayClient;
        public AlipayF2FService(IOptions<AlipayOptions> alipayOptions)
        {
            Options = alipayOptions.Value;
            _alipayClient = F2FBiz.CreateClientInstance(Options.Gatewayurl, Options.AppId, Options.PrivateKey, "1.0",
                Options.SignType, Options.AlipayPublicKey, Options.CharSet);
        }

        public AlipayF2FPayResult TradePay(AlipayTradePayContentBuilder builder)
        {
            return _alipayClient.tradePay(builder);
        }

        public AlipayF2FQueryResult TradeQuery(string outTradeNo)
        {
            return _alipayClient.tradeQuery(outTradeNo);
        }

        public AlipayF2FRefundResult TradeRefund(AlipayTradeRefundContentBuilder builder)
        {
            return _alipayClient.tradeRefund(builder);
        }

        public AlipayF2FPrecreateResult TradePrecreate(AlipayTradePrecreateContentBuilder builder)
        {
            return _alipayClient.tradePrecreate(builder);
        }

        public AlipayF2FPrecreateResult TradePrecreate(AlipayTradePrecreateContentBuilder builder, string notify_url)
        {
            return _alipayClient.tradePrecreate(builder, notify_url);
        }
    }
}