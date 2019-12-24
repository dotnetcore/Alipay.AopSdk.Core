using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// VoucherDescDetail Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherDescDetail : AopObject
    {
        /// <summary>
        /// 具体描述信息列表
        /// </summary>
        [XmlArray("details")]
        [XmlArrayItem("string")]
        public List<string> Details { get; set; }

        /// <summary>
        /// 图片描述信息
        /// </summary>
        [XmlArray("images")]
        [XmlArrayItem("string")]
        public List<string> Images { get; set; }

        /// <summary>
        /// 券说明的标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 券外部详情描述
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
