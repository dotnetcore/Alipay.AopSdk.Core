using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ArrangementNoQuerier Data Structure.
    /// </summary>
    [Serializable]
    public class ArrangementNoQuerier : AopObject
    {
        /// <summary>
        /// 合约编号列表
        /// </summary>
        [XmlArray("ar_nos")]
        [XmlArrayItem("string")]
        public List<string> ArNos { get; set; }
    }
}
