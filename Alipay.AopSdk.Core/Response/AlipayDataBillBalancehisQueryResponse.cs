using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayDataBillBalancehisQueryResponse.
    /// </summary>
    public class AlipayDataBillBalancehisQueryResponse : AopResponse
    {
        /// <summary>
        /// 期初余额
        /// </summary>
        [XmlElement("beginning_balance")]
        public string BeginningBalance { get; set; }

        /// <summary>
        /// 期末余额
        /// </summary>
        [XmlElement("ending_balance")]
        public string EndingBalance { get; set; }
    }
}
