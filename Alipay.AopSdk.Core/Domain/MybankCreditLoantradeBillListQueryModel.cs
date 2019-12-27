using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MybankCreditLoantradeBillListQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoantradeBillListQueryModel : AopObject
    {
        /// <summary>
        /// 账单状态，OVD逾期，CLE结清，NOR正常
        /// </summary>
        [XmlElement("bill_status_list")]
        public string BillStatusList { get; set; }

        /// <summary>
        /// 账单结束时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 分页偏移量
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小，最大50
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 方案合约编号
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 账单开始时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 用户的基本信息，包括支付宝id，site,steUserId等
        /// </summary>
        [XmlElement("user")]
        public UserVo User { get; set; }
    }
}
