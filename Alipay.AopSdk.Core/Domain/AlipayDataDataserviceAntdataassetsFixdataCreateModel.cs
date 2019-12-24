using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAntdataassetsFixdataCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAntdataassetsFixdataCreateModel : AopObject
    {
        /// <summary>
        /// 该字段指定补数据的结束分区
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// ODPS表的guid
        /// </summary>
        [XmlElement("guid")]
        public string Guid { get; set; }

        /// <summary>
        /// 该字段指定补数据的开始分区
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
