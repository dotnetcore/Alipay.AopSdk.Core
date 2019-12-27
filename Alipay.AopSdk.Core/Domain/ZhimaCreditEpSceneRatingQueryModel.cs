using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ZhimaCreditEpSceneRatingQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpSceneRatingQueryModel : AopObject
    {
        /// <summary>
        /// 芝麻企业信用评估订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
