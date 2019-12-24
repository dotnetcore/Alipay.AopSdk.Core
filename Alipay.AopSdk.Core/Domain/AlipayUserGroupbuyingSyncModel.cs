using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayUserGroupbuyingSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserGroupbuyingSyncModel : AopObject
    {
        /// <summary>
        /// 拼团结束时间的timestamp
        /// </summary>
        [XmlElement("group_expire")]
        public string GroupExpire { get; set; }

        /// <summary>
        /// 相关拼团的Id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 1688处的用户havanaId
        /// </summary>
        [XmlElement("havana_id")]
        public string HavanaId { get; set; }

        /// <summary>
        /// 1688处商品Id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
