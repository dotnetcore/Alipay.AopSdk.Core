using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// IndirectIsvInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IndirectIsvInfo : AopObject
    {
        /// <summary>
        /// 是否绑定间连天梭  true表示绑定  false表示未绑定
        /// </summary>
        [XmlElement("is_ts_binding")]
        public string IsTsBinding { get; set; }

        /// <summary>
        /// 间连商户服务商名称
        /// </summary>
        [XmlElement("isv_name")]
        public string IsvName { get; set; }

        /// <summary>
        /// 间连商户服务商pid
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }
    }
}
