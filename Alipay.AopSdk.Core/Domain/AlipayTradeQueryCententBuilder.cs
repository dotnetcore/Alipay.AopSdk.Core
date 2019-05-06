using System;

namespace Alipay.AopSdk.F2FPay.Domain
{
    /// <summary>
    /// AlipayTradeQueryCententBuilder 的摘要说明
    /// </summary>
    public class AlipayTradeQueryContentBuilder : JsonBuilder
    {


        public string trade_no { get; set; }
        public string out_trade_no { get; set; }


        public AlipayTradeQueryContentBuilder()
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