using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// ZhimaCreditEpSceneRatingInitializeResponse.
    /// </summary>
    public class ZhimaCreditEpSceneRatingInitializeResponse : AopResponse
    {
        /// <summary>
        /// 芝麻企业信用评估单号，商户应该妥善关联持久化保存该订单号用于后续的对账。
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
