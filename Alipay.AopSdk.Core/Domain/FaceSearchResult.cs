using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// FaceSearchResult Data Structure.
    /// </summary>
    [Serializable]
    public class FaceSearchResult : AopObject
    {
        /// <summary>
        /// faceType
        /// </summary>
        [XmlElement("face_type")]
        public string FaceType { get; set; }

        /// <summary>
        /// 分数
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 身份证姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
