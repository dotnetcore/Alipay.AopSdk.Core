using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// BusinessPoint Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessPoint : AopObject
    {
        /// <summary>
        /// 点位描述
        /// </summary>
        [XmlElement("point_desc")]
        public string PointDesc { get; set; }

        /// <summary>
        /// 业务点位id
        /// </summary>
        [XmlElement("point_id")]
        public long PointId { get; set; }

        /// <summary>
        /// 点位名称
        /// </summary>
        [XmlElement("point_name")]
        public string PointName { get; set; }

        /// <summary>
        /// 点位备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 点位状态
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }
    }
}
