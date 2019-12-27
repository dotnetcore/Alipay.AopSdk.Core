using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenOperationBizfeeAftechConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationBizfeeAftechConsultModel : AopObject
    {
        /// <summary>
        /// 系统/应用名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 业务流水号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 客户信息（JSON对象） 包含principalType主体类型、principalId主体Id、extInfo扩展信息等字段。其中，需要从extInfo透传消费的key有：relEntityId关联主体Id。
        /// </summary>
        [XmlElement("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// 事件码列表（List<String>的JSON对象）
        /// </summary>
        [XmlElement("event_codes")]
        public string EventCodes { get; set; }

        /// <summary>
        /// 计价时间
        /// </summary>
        [XmlElement("gmt_charge")]
        public string GmtCharge { get; set; }

        /// <summary>
        /// 外部业务流水号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 扩展属性（Map<String, String>的JSON对象） key和value中不能有英文逗号及等于符号。
        /// </summary>
        [XmlElement("properties")]
        public string Properties { get; set; }

        /// <summary>
        /// 租户Id
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
