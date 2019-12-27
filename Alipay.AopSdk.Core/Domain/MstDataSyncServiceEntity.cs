using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MstDataSyncServiceEntity Data Structure.
    /// </summary>
    [Serializable]
    public class MstDataSyncServiceEntity : AopObject
    {
        /// <summary>
        /// 业务数据唯一id
        /// </summary>
        [XmlElement("biz_uniq_id")]
        public string BizUniqId { get; set; }

        /// <summary>
        /// 自定义扩展信息，JSON字符串。
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 业务数据操作类型。add-新增，modify-修改，delete-删除。业务方负责数据的生命周期管理，当一个连接不再需要检测时，应及时通知巡检平台删除。当一个业务连接改变时，也应及时通知巡检平台更新。
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 业务数据名称
        /// </summary>
        [XmlElement("service_title")]
        public string ServiceTitle { get; set; }

        /// <summary>
        /// 业务数据连接。必须是有效的url
        /// </summary>
        [XmlElement("service_url")]
        public string ServiceUrl { get; set; }
    }
}
