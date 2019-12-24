using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AssetLogisticsRecord Data Structure.
    /// </summary>
    [Serializable]
    public class AssetLogisticsRecord : AopObject
    {
        /// <summary>
        /// 物流节点详情描述
        /// </summary>
        [XmlElement("last_logistics_detail")]
        public string LastLogisticsDetail { get; set; }

        /// <summary>
        /// 物流公司Code
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 物流时间
        /// </summary>
        [XmlElement("logistics_gmt_modified")]
        public string LogisticsGmtModified { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [XmlElement("logistics_no")]
        public string LogisticsNo { get; set; }

        /// <summary>
        /// 物流状态
        /// </summary>
        [XmlElement("logistics_status")]
        public string LogisticsStatus { get; set; }

        /// <summary>
        /// 物流状态描述
        /// </summary>
        [XmlElement("logistics_status_desc")]
        public string LogisticsStatusDesc { get; set; }
    }
}
