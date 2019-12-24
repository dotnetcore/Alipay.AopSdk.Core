using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntMerchantExpandIndirectTiansuoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandIndirectTiansuoQueryModel : AopObject
    {
        /// <summary>
        /// 间连商户入驻时填写的营业执照号
        /// </summary>
        [XmlElement("business_license_no")]
        public string BusinessLicenseNo { get; set; }
    }
}
