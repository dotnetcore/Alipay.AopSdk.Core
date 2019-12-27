using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayCommerceIotSdarttoolPrintSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotSdarttoolPrintSendModel : AopObject
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 唯一请求流水号
        /// </summary>
        [XmlElement("outer_no")]
        public string OuterNo { get; set; }

        /// <summary>
        /// 打印内容
        /// </summary>
        [XmlElement("print_content")]
        public string PrintContent { get; set; }

        /// <summary>
        /// 打印模板
        /// </summary>
        [XmlElement("print_template")]
        public string PrintTemplate { get; set; }

        /// <summary>
        /// 打印的业务场景
        /// </summary>
        [XmlElement("sence")]
        public string Sence { get; set; }

        /// <summary>
        /// 设备sn号
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 设备供应商ID
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }

        /// <summary>
        /// 走纸行数默为03
        /// </summary>
        [XmlElement("walk_paper")]
        public string WalkPaper { get; set; }
    }
}
