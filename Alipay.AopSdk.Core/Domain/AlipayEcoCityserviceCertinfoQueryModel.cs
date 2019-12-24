using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEcoCityserviceCertinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCityserviceCertinfoQueryModel : AopObject
    {
        /// <summary>
        /// 用户证件信息列表。
        /// </summary>
        [XmlArray("cert_infos")]
        [XmlArrayItem("cert_info_request")]
        public List<CertInfoRequest> CertInfos { get; set; }
    }
}
