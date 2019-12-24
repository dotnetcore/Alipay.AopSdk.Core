using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntMerchantExpandOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandOrderQueryModel : AopObject
    {
        /// <summary>
        /// 通过ant.merchant.expand.indirect.zmsub.create等接口进件时返回的order_id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
