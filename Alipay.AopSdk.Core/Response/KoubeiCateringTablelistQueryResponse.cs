using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// KoubeiCateringTablelistQueryResponse.
    /// </summary>
    public class KoubeiCateringTablelistQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回tablelistresult列表
        /// </summary>
        [XmlElement("tableinfo_result")]
        public TableInfoResult TableinfoResult { get; set; }
    }
}
