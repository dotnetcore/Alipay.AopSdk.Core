using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayInsSceneInsserviceprodSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneInsserviceprodSyncModel : AopObject
    {
        /// <summary>
        /// 扩展信息，JSON字符串格式
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 当前节点名称
        /// </summary>
        [XmlElement("cur_node")]
        public string CurNode { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
