using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayDataIotdataDataTotalQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataIotdataDataTotalQueryModel : AopObject
    {
        /// <summary>
        /// 业务id
        /// </summary>
        [XmlElement("business_id")]
        public long BusinessId { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public long EndTime { get; set; }

        /// <summary>
        /// 点位id
        /// </summary>
        [XmlElement("point_id")]
        public long PointId { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_time")]
        public long StartTime { get; set; }

        /// <summary>
        /// 子业务id
        /// </summary>
        [XmlElement("sub_biz_id")]
        public string SubBizId { get; set; }
    }
}
