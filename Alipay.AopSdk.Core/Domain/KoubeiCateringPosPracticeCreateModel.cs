using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiCateringPosPracticeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosPracticeCreateModel : AopObject
    {
        /// <summary>
        /// 做法名称
        /// </summary>
        [XmlElement("practice_name")]
        public string PracticeName { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
