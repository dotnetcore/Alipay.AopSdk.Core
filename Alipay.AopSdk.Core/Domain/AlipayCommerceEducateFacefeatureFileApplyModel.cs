using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayCommerceEducateFacefeatureFileApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateFacefeatureFileApplyModel : AopObject
    {
        /// <summary>
        /// 学校团餐
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 需要请求的特征版本
        /// </summary>
        [XmlElement("feature_version")]
        public string FeatureVersion { get; set; }

        /// <summary>
        /// 需要请求的文件日期
        /// </summary>
        [XmlElement("file_date")]
        public string FileDate { get; set; }

        /// <summary>
        /// 需要请求的文件类型,ALL:全量,INCREASE:增量,REALTIME:实时
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 机构ID
        /// </summary>
        [XmlElement("institution_id")]
        public string InstitutionId { get; set; }

        /// <summary>
        /// 合作机构简称
        /// </summary>
        [XmlElement("isv_name")]
        public string IsvName { get; set; }
    }
}
