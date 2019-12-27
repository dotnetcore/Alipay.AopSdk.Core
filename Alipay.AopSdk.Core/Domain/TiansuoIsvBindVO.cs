using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// TiansuoIsvBindVO Data Structure.
    /// </summary>
    [Serializable]
    public class TiansuoIsvBindVO : AopObject
    {
        /// <summary>
        /// 间连商户入驻时填写的营业执照号
        /// </summary>
        [XmlElement("business_license_no")]
        public string BusinessLicenseNo { get; set; }

        /// <summary>
        /// 服务商pid
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 操作类型  bind 绑定  unbind 解绑
        /// </summary>
        [XmlElement("operation")]
        public string Operation { get; set; }
    }
}
