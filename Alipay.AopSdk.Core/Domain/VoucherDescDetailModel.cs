using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// VoucherDescDetailModel Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherDescDetailModel : AopObject
    {
        /// <summary>
        /// 优惠的说明信息
        /// </summary>
        [XmlArray("details")]
        [XmlArrayItem("string")]
        public List<string> Details { get; set; }

        /// <summary>
        /// 优惠的标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
