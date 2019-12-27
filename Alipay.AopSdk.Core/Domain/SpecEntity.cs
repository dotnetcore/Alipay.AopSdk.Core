using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// SpecEntity Data Structure.
    /// </summary>
    [Serializable]
    public class SpecEntity : AopObject
    {
        /// <summary>
        /// 新增不用传，修改必须传
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 规格名称
        /// </summary>
        [XmlElement("spec_name")]
        public string SpecName { get; set; }

        /// <summary>
        /// 是否为系统默认规格,同步时，默认为false，设置不生效，只有查询现实时用
        /// </summary>
        [XmlElement("system")]
        public bool System { get; set; }
    }
}
