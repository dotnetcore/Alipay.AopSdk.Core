using System;

namespace Alipay.AopSdk.F2FPay.Domain
{
    /// <summary>
    /// AlipayTradeRefundContentBuilder 的摘要说明
    /// </summary>
    public class AlipayTradeRefundContentBuilder : JsonBuilder
    {


        public string trade_no { get; set; }

        public string out_trade_no { get; set; }

        public string refund_amount { get; set; }

        public string out_request_no { get; set; }

        public string refund_reason { get; set; }


        public AlipayTradeRefundContentBuilder()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

        public override bool Validate()
        {
            throw new NotImplementedException();
        }


    }
}