using Alipay.AopSdk.F2FPay.Domain;

namespace Alipay.AopSdk.F2FPay.Business
{
    /// <summary>
    /// IAlipayTrade 的摘要说明
    /// </summary>
    public interface IAlipayTradeService
    {
        //当面付条码支付
         AlipayF2FPayResult tradePay(AlipayTradePayContentBuilder builder);

        // 当面付2.0交易查询
         AlipayF2FQueryResult tradeQuery(string outTradeNo);

        // 当面付2.0交易退货
         AlipayF2FRefundResult tradeRefund(AlipayTradeRefundContentBuilder builder);

        // 当面付2.0预下单
         AlipayF2FPrecreateResult tradePrecreate(AlipayTradePrecreateContentBuilder builder);
         AlipayF2FPrecreateResult tradePrecreate(AlipayTradePrecreateContentBuilder builder, string notify_url);

        //云监控接口
         //AlipayF2FMonitorResult mcloudMonitor(AlipayMonitorContentBuilder builder);
    }

}