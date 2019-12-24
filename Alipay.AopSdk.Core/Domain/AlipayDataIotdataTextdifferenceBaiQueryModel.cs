using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayDataIotdataTextdifferenceBaiQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataIotdataTextdifferenceBaiQueryModel : AopObject
    {
        /// <summary>
        /// 文档的文本内容。
        /// </summary>
        [XmlElement("text_s")]
        public string TextS { get; set; }

        /// <summary>
        /// 文档文本
        /// </summary>
        [XmlElement("text_t")]
        public string TextT { get; set; }
    }
}
