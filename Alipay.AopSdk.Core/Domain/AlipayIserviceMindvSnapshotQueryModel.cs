using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayIserviceMindvSnapshotQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceMindvSnapshotQueryModel : AopObject
    {
        /// <summary>
        /// 问卷/试卷快照id信息，供系统检索快照内容
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }
    }
}
