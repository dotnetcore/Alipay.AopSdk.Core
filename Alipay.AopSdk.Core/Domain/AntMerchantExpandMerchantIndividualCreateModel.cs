using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntMerchantExpandMerchantIndividualCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandMerchantIndividualCreateModel : AopObject
    {
        /// <summary>
        /// 商户证件编号（企业或者个体工商户提供营业执照，事业单位提供事证号）
        /// </summary>
        [XmlElement("business_license")]
        public string BusinessLicense { get; set; }

        /// <summary>
        /// 营业执照图片，图片字节流base64编码后传入。
        /// </summary>
        [XmlElement("business_license_pic")]
        public string BusinessLicensePic { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
