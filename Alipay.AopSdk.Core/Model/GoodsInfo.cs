namespace Alipay.AopSdk.F2FPay.Model
{
    /// <summary>
    /// GoodsInfo 的摘要说明
    /// </summary>
    public class GoodsInfo
    {
        public string goods_id { get; set; }

        public string alipay_goods_id { get; set; }

        public string goods_name { get; set; }

        public string quantity { get; set; }
        public string price { get; set; }

        public string goods_category { get; set; }

        public string body { get; set; }

        public GoodsInfo()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
    }
}