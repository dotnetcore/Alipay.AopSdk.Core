using System.Threading.Tasks;
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
            return _alipayClient.TradePay(builder);
        }

        public AlipayF2FQueryResult TradeQuery(string outTradeNo)
        {
            return _alipayClient.TradeQuery(outTradeNo);
        }

        public async Task<AlipayF2FQueryResult> TradeQueryAsync(string outTradeNo)
        {
            return await _alipayClient.TradeQueryAsync(outTradeNo);
        }

        public AlipayF2FRefundResult TradeRefund(AlipayTradeRefundContentBuilder builder)
        {
            return _alipayClient.TradeRefund(builder);
        }

        public async Task<AlipayF2FRefundResult> TradeRefundAsync(AlipayTradeRefundContentBuilder builder)
        {
            return await _alipayClient.TradeRefundAsync(builder);
        }

        public AlipayF2FPrecreateResult TradePrecreate(AlipayTradePrecreateContentBuilder builder)
        {
            return _alipayClient.TradePrecreate(builder);
        }

        public async Task<AlipayF2FPrecreateResult> TradePrecreateAsync(AlipayTradePrecreateContentBuilder builder)
        {
            return await _alipayClient.TradePrecreateAsync(builder);
        }

        public AlipayF2FPrecreateResult TradePrecreate(AlipayTradePrecreateContentBuilder builder, string notifyUrl)
        {
            return _alipayClient.TradePrecreate(builder, notifyUrl);
        }

        public async Task<AlipayF2FPrecreateResult> TradePrecreateAsync(AlipayTradePrecreateContentBuilder builder, string notifyUrl)
        {
            return await _alipayClient.TradePrecreateAsync(builder, notifyUrl);
        }
    }
}