using System.Threading.Tasks;
using Alipay.AopSdk.F2FPay.Domain;

namespace Alipay.AopSdk.F2FPay.Business
{
    /// <summary>
    /// IAlipayTrade 的摘要说明
    /// </summary>
    public interface IAlipayTradeService
    {
        //当面付条码支付
         AlipayF2FPayResult TradePay(AlipayTradePayContentBuilder builder);

        // 当面付2.0交易查询
         AlipayF2FQueryResult TradeQuery(string outTradeNo);

        // 当面付2.0交易退货
         AlipayF2FRefundResult TradeRefund(AlipayTradeRefundContentBuilder builder);

        // 当面付2.0预下单
         AlipayF2FPrecreateResult TradePrecreate(AlipayTradePrecreateContentBuilder builder);
         AlipayF2FPrecreateResult TradePrecreate(AlipayTradePrecreateContentBuilder builder, string notify_url);

        //云监控接口
         //AlipayF2FMonitorResult mcloudMonitor(AlipayMonitorContentBuilder builder);
        Task<AlipayF2FQueryResult> TradeQueryAsync(string outTradeNo);
        Task<AlipayF2FRefundResult> TradeRefundAsync(AlipayTradeRefundContentBuilder builder);
        Task<AlipayF2FPrecreateResult> TradePrecreateAsync(AlipayTradePrecreateContentBuilder builder);
        Task<AlipayF2FPrecreateResult> TradePrecreateAsync(AlipayTradePrecreateContentBuilder builder, string notify_url);
    }

}