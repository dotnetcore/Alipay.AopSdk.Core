using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// BookTime Data Structure.
    /// </summary>
    [Serializable]
    public class BookTime : AopObject
    {
        /// <summary>
        /// 可预定时间段。格式： HH:mm:ss
        /// </summary>
        [XmlArray("time")]
        [XmlArrayItem("string")]
        public List<string> Time { get; set; }

        /// <summary>
        /// 可预订周几。如1表示周一；2：周二；3：周三；4：周四；5：周五；6：周六；7：周日
        /// </summary>
        [XmlElement("week")]
        public long Week { get; set; }
    }
}
