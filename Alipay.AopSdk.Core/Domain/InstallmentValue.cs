using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// InstallmentValue Data Structure.
    /// </summary>
    [Serializable]
    public class InstallmentValue : AopObject
    {
        /// <summary>
        /// 分段值
        /// </summary>
        [XmlArray("installment_values")]
        [XmlArrayItem("installment_meta_info")]
        public List<InstallmentMetaInfo> InstallmentValues { get; set; }
    }
}
