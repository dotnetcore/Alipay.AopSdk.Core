using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiMallScanpurchaseUserverifyVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMallScanpurchaseUserverifyVerifyModel : AopObject
    {
        /// <summary>
        /// 口碑店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 核销码
        /// </summary>
        [XmlElement("verify_code")]
        public string VerifyCode { get; set; }
    }
}
