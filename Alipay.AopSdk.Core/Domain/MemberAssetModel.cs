using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MemberAssetModel Data Structure.
    /// </summary>
    [Serializable]
    public class MemberAssetModel : AopObject
    {
        /// <summary>
        /// 权益类型，目前只支持2种。  BALANCE：金额   POINT：积分
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
