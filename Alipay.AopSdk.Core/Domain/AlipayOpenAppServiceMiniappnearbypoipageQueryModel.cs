using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenAppServiceMiniappnearbypoipageQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppServiceMiniappnearbypoipageQueryModel : AopObject
    {
        /// <summary>
        /// 当前页数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 服务编码
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }
    }
}
