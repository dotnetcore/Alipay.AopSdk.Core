using System;
using System.Collections.Generic;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayTradePayContentBuilder 的摘要说明
    /// </summary>
    public class AlipayTradePayContentBuilder : JsonBuilder
    {
        public string out_trade_no {get;set;}
        public string seller_id {get;set;}
        public string total_amount { get; set; }
        public string discountable_amount { get; set; }
        public string undiscountable_amount { get; set; }
        public string subject { get; set; }
        public string body { get; set; }

        public List<F2FPay.Model.GoodsInfo> goods_detail{get;set;}
        public string operator_id { get; set; }

        public string store_id { get; set; }

        public string terminal_id { get; set; }

        public F2FPay.Model.ExtendParams extend_params;
        public string timeout_express { get; set; }


        public AlipayTradePayContentBuilder()
        {
            this.scene = "bar_code";
        }

        public string scene { get; set; }

        public string auth_code { get; set; }




         public override bool Validate()
        {
            if (String.IsNullOrEmpty(scene))
            {
                throw new NullReferenceException("scene should not be NULL!");
            }
            if (String.IsNullOrEmpty(auth_code))
            {
                throw new NullReferenceException("auth_code should not be NULL!");
            }
            return true;
        }
    }

}