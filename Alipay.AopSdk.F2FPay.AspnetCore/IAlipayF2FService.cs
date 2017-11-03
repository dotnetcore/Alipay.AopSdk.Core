using Alipay.AopSdk.F2FPay.Business;
using Alipay.AopSdk.F2FPay.Domain;

namespace Alipay.AopSdk.F2FPay.AspnetCore
{
	public interface IAlipayF2FService
	{
		/// <summary>
		/// 当面付条码支付
		/// </summary>
		/// <param name="builder"></param>
		/// <returns></returns>
		AlipayF2FPayResult TradePay(AlipayTradePayContentBuilder builder);

		/// <summary>
		/// 当面付2.0交易查询
		/// </summary>
		/// <param name="outTradeNo"></param>
		/// <returns></returns>
		AlipayF2FQueryResult TradeQuery(string outTradeNo);

		/// <summary>
		/// 当面付2.0交易退货
		/// </summary>
		/// <param name="builder"></param>
		/// <returns></returns>
		AlipayF2FRefundResult TradeRefund(AlipayTradeRefundContentBuilder builder);

		/// <summary>
		/// 当面付2.0预下单
		/// </summary>
		/// <param name="builder"></param>
		/// <returns></returns>
		AlipayF2FPrecreateResult TradePrecreate(AlipayTradePrecreateContentBuilder builder);

		/// <summary>
		/// 当面付2.0预下单
		/// </summary>
		/// <param name="builder"></param>
		/// <param name="notify_url"></param>
		/// <returns></returns>
		AlipayF2FPrecreateResult TradePrecreate(AlipayTradePrecreateContentBuilder builder, string notify_url);
	}
}