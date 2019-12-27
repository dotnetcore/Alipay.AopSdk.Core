using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ZhimaCreditPeIndustryOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeIndustryOrderSyncModel : AopObject
    {
        /// <summary>
        /// 业务场景,分时租赁平台:car_sharing_zhima,具体业务对应的业务场景请联系业务确认
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 订单待同步信息,不能为空，json格式字符串，自定义key需要提前与接口owner进行沟通确认,注意:如果字符串对应的json对象包含中文字符，需要对包含中文的字段进行编码
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商户的外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 签约产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 平台订单号
        /// </summary>
        [XmlElement("zm_order_id")]
        public string ZmOrderId { get; set; }
    }
}
