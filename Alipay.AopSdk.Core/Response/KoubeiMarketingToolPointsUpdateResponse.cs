using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// KoubeiMarketingToolPointsUpdateResponse.
    /// </summary>
    public class KoubeiMarketingToolPointsUpdateResponse : AopResponse
    {
        /// <summary>
        /// 集点变更流水号
        /// </summary>
        [XmlElement("point_log_no")]
        public string PointLogNo { get; set; }
    }
}
