using Alipay.AopSdk.Core.Domain;
using Alipay.AopSdk.Core.Response;

namespace Alipay.AopSdk.F2FPay.Business
{
    /// <summary>
    /// AlipayF2FPayResult 的摘要说明
    /// </summary>
    public class AlipayF2FQueryResult
    {
        public AlipayF2FQueryResult()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

        public AlipayTradeQueryResponse response { get; set; }

        public ResultEnum Status
        {
            get
            {
                if (response != null)
                {
                    if (response.Code == ResultCode.SUCCESS &&
                        (response.TradeStatus.Equals(TradeStatus.TRADE_SUCCESS) || response.TradeStatus.Equals(TradeStatus.TRADE_FINISHED)))
                    {
                        return ResultEnum.SUCCESS;
                    }
                    if (response.Code == ResultCode.ERROR)
                    {
                        return ResultEnum.UNKNOWN;
                    }
                    else
                        return ResultEnum.FAILED;
                }
                else
                {
                    return ResultEnum.UNKNOWN;
                }
            }
        }

    }
}