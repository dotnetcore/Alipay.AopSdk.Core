using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoListQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerbaseinfoListQueryModel : AopObject
    {
        /// <summary>
        /// 普通小程序/插件/模板
        /// </summary>
        [XmlElement("app_sub_type")]
        public string AppSubType { get; set; }

        /// <summary>
        /// 开发者ID
        /// </summary>
        [XmlElement("developer_id")]
        public string DeveloperId { get; set; }

        /// <summary>
        /// 租户编码
        /// </summary>
        [XmlElement("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 页数-0开始
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页个数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
