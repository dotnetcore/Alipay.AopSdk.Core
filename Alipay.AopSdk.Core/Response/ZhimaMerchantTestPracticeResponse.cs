using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// ZhimaMerchantTestPracticeResponse.
    /// </summary>
    public class ZhimaMerchantTestPracticeResponse : AopResponse
    {
        /// <summary>
        /// xxxx
        /// </summary>
        [XmlElement("dddd")]
        public XXXXsdasdasd Dddd { get; set; }

        /// <summary>
        /// ccc
        /// </summary>
        [XmlElement("sss")]
        public string Sss { get; set; }
    }
}
