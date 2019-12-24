using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// SummaryData Data Structure.
    /// </summary>
    [Serializable]
    public class SummaryData : AopObject
    {
        /// <summary>
        /// 成年人客流数
        /// </summary>
        [XmlElement("adult")]
        public long Adult { get; set; }

        /// <summary>
        /// 平均截留时间
        /// </summary>
        [XmlElement("avg_stop_time")]
        public string AvgStopTime { get; set; }

        /// <summary>
        /// 背面截留率
        /// </summary>
        [XmlElement("back_interception_rate")]
        public string BackInterceptionRate { get; set; }

        /// <summary>
        /// 老年人客流数
        /// </summary>
        [XmlElement("elder")]
        public long Elder { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public long EndTime { get; set; }

        /// <summary>
        /// 正面截留率
        /// </summary>
        [XmlElement("face_interception_rate")]
        public string FaceInterceptionRate { get; set; }

        /// <summary>
        /// 女性客流数
        /// </summary>
        [XmlElement("female")]
        public long Female { get; set; }

        /// <summary>
        /// 男性客流数
        /// </summary>
        [XmlElement("male")]
        public long Male { get; set; }

        /// <summary>
        /// 未成年客流数
        /// </summary>
        [XmlElement("nonage")]
        public long Nonage { get; set; }

        /// <summary>
        /// 感知客流量
        /// </summary>
        [XmlElement("person_view")]
        public long PersonView { get; set; }

        /// <summary>
        /// 侧面截留率
        /// </summary>
        [XmlElement("side_interception_rate")]
        public string SideInterceptionRate { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_time")]
        public long StartTime { get; set; }
    }
}
