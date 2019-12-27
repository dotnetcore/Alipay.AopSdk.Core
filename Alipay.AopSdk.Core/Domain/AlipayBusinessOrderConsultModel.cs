using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayBusinessOrderConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBusinessOrderConsultModel : AopObject
    {
        /// <summary>
        /// 买家识别信息。  本接口场景下若无用户id信息，可扫用户付款页中条形码，传入条码信息（type为BAR_CODE，issuer为ALIPAY，identity为获取的用户条形码码值）
        /// </summary>
        [XmlElement("buyer_identity")]
        public UserIdentity BuyerIdentity { get; set; }

        /// <summary>
        /// 经营环境信息
        /// </summary>
        [XmlElement("env_info")]
        public EnvInfo EnvInfo { get; set; }

        /// <summary>
        /// 商品详情列表
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("item_detail")]
        public List<ItemDetail> ItemList { get; set; }
    }
}
