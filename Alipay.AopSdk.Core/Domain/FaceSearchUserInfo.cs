using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// FaceSearchUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FaceSearchUserInfo : AopObject
    {
        /// <summary>
        /// 自定义用户标识
        /// </summary>
        [XmlElement("customuserid")]
        public string Customuserid { get; set; }

        /// <summary>
        /// 商户标识
        /// </summary>
        [XmlElement("merchantid")]
        public string Merchantid { get; set; }

        /// <summary>
        /// 商户uid
        /// </summary>
        [XmlElement("merchantuid")]
        public string Merchantuid { get; set; }

        /// <summary>
        /// 分数
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }
    }
}
