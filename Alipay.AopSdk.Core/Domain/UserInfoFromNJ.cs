using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// UserInfoFromNJ Data Structure.
    /// </summary>
    [Serializable]
    public class UserInfoFromNJ : AopObject
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("company")]
        public string Company { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [XmlElement("tel")]
        public string Tel { get; set; }
    }
}
