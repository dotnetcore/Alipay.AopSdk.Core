using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiCateringConfigModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringConfigModifyModel : AopObject
    {
        /// <summary>
        /// 外部请求ID; 标识ISV本次修改的请求，由开发者自定义，不同的请求使用不同的ID，在门店notify消息中也会带有该参数，以此标明本次notify消息是对哪个请求的回应
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 店铺配置信息列表
        /// </summary>
        [XmlArray("shop_config_list")]
        [XmlArrayItem("shop_order_config_info")]
        public List<ShopOrderConfigInfo> ShopConfigList { get; set; }
    }
}
