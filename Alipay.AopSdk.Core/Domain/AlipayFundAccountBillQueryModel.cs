using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayFundAccountBillQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundAccountBillQueryModel : AopObject
    {
        /// <summary>
        /// 开户场景码
        /// </summary>
        [XmlElement("account_scene_code")]
        public string AccountSceneCode { get; set; }

        /// <summary>
        /// 支付宝用户uid
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 账单开始时间
        /// </summary>
        [XmlElement("bill_begin_time")]
        public string BillBeginTime { get; set; }

        /// <summary>
        /// 账单结束时间
        /// </summary>
        [XmlElement("bill_end_time")]
        public string BillEndTime { get; set; }

        /// <summary>
        /// JSON格式，传递业务扩展参数，使用前请与支付宝工程师联系！
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商户会员的唯一标识
        /// </summary>
        [XmlElement("merchant_user_id")]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// 查询页码，必须大于0
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 分页大小，每页条目数需满足0< page_size < 100
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
