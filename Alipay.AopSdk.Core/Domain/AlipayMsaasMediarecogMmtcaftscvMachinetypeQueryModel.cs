using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvMachinetypeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogMmtcaftscvMachinetypeQueryModel : AopObject
    {
        /// <summary>
        /// 类型(0:商品库机型, 1:摆放模板机型)
        /// </summary>
        [XmlElement("type")]
        public long Type { get; set; }
    }
}
