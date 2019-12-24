using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEbppDetectReportQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppDetectReportQueryModel : AopObject
    {
        /// <summary>
        /// 外部业务标识
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
