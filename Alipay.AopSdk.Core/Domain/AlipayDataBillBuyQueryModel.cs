using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayDataBillBuyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataBillBuyQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝交易流水号。如果查询参数中指定流水号，则只查询流水号相关的记录
        /// </summary>
        [XmlElement("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 交易流水创建时间的结束范围。与起始时间间隔不超过31天。查询结果为起始时间至结束时间的左闭右开区间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 商户交易号。如果查询参数中指定交易号，则只查询相关的记录
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 分页号，从1开始
        /// </summary>
        [XmlElement("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 分页大小1000-2000，默认2000
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 交易流水创建时间的起始范围
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 门店编号，模糊搜索
        /// </summary>
        [XmlElement("store_no")]
        public string StoreNo { get; set; }
    }
}
