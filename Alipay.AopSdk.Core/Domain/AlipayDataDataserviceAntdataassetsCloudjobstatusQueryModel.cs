using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAntdataassetsCloudjobstatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAntdataassetsCloudjobstatusQueryModel : AopObject
    {
        /// <summary>
        /// 分区信息
        /// </summary>
        [XmlElement("bizdate")]
        public string Bizdate { get; set; }

        /// <summary>
        /// ODPS表的guid
        /// </summary>
        [XmlElement("guid")]
        public string Guid { get; set; }
    }
}
