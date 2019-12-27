using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayDataIotdataBusinessPointCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataIotdataBusinessPointCreateModel : AopObject
    {
        /// <summary>
        /// 业务id
        /// </summary>
        [XmlElement("business_id")]
        public long BusinessId { get; set; }

        /// <summary>
        /// 点位描述，可以是点位的具体地址
        /// </summary>
        [XmlElement("point_desc")]
        public string PointDesc { get; set; }

        /// <summary>
        /// 点位名称
        /// </summary>
        [XmlElement("point_name")]
        public string PointName { get; set; }

        /// <summary>
        /// 点位备注信息
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }
    }
}
