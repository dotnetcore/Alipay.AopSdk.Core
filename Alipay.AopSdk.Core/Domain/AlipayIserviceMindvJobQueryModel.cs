using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayIserviceMindvJobQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceMindvJobQueryModel : AopObject
    {
        /// <summary>
        /// 问卷id_系统内唯一_根据问卷id查询问卷相关信息
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }
    }
}
