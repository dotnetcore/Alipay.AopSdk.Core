using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEbppInspectCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInspectCreateModel : AopObject
    {
        /// <summary>
        /// 业务类型。由巡检平台统一分配。
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 数据创建者
        /// </summary>
        [XmlElement("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 数据来源: 业务系统名称_TrSync
        /// </summary>
        [XmlElement("data_from_type")]
        public string DataFromType { get; set; }

        /// <summary>
        /// 是否同步检测。true-同步检测，false-不需要同步检测。默认false。
        /// </summary>
        [XmlElement("is_sync_check")]
        public bool IsSyncCheck { get; set; }

        /// <summary>
        /// 外部流程业务标识。一个标识可以同步多条数据。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 业务服务数据列表
        /// </summary>
        [XmlArray("service_list")]
        [XmlArrayItem("mst_data_sync_service_entity")]
        public List<MstDataSyncServiceEntity> ServiceList { get; set; }
    }
}
