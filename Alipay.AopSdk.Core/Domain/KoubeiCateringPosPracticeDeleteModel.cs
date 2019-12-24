using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiCateringPosPracticeDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosPracticeDeleteModel : AopObject
    {
        /// <summary>
        /// 做法id
        /// </summary>
        [XmlElement("practice_id")]
        public string PracticeId { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
