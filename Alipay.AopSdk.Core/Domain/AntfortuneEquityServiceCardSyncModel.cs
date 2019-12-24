using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntfortuneEquityServiceCardSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneEquityServiceCardSyncModel : AopObject
    {
        /// <summary>
        /// 服务动态信息列表
        /// </summary>
        [XmlArray("contents")]
        [XmlArrayItem("fs_service_dynamic_info")]
        public List<FsServiceDynamicInfo> Contents { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 服务id
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }
    }
}
