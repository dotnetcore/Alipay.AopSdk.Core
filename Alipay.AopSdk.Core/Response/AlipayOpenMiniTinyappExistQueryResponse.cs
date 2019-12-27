using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayOpenMiniTinyappExistQueryResponse.
    /// </summary>
    public class AlipayOpenMiniTinyappExistQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否是小程序开发者
        /// </summary>
        [XmlElement("exist_mini")]
        public string ExistMini { get; set; }
    }
}
