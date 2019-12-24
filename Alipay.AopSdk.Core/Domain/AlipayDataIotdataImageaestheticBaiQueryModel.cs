using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayDataIotdataImageaestheticBaiQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataIotdataImageaestheticBaiQueryModel : AopObject
    {
        /// <summary>
        /// 用于标识不同的业务方
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 用于标识当次的图片base64数据
        /// </summary>
        [XmlElement("image_base_64")]
        public string ImageBase64 { get; set; }

        /// <summary>
        /// 图片的oss url地址
        /// </summary>
        [XmlElement("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 用于标识当次请求
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// url 或 base64
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
