using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionConditionBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionConditionBatchqueryModel : AopObject
    {
        /// <summary>
        /// 业务来源
        /// </summary>
        [XmlElement("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// com.alipay.alipaywallet:支付宝，com.amap.app:高德
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 小程序应用ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 分页数
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// INIT:开发中，RELEASE:上架，OFFLINE:下架，AUDITING:审核中，AUDIT_REJECT:审核驳回，WAIT_RELEASE:待上架，GRAY:灰度中，以,号隔开
        /// </summary>
        [XmlElement("version_status")]
        public string VersionStatus { get; set; }
    }
}
