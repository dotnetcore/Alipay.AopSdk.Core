using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// CustScpBillAmtVO Data Structure.
    /// </summary>
    [Serializable]
    public class CustScpBillAmtVO : AopObject
    {
        /// <summary>
        /// 费用
        /// </summary>
        [XmlElement("fee")]
        public string Fee { get; set; }

        /// <summary>
        /// 本金
        /// </summary>
        [XmlElement("prin")]
        public string Prin { get; set; }
    }
}
