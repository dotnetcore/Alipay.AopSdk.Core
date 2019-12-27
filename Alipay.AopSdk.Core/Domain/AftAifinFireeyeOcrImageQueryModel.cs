using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AftAifinFireeyeOcrImageQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AftAifinFireeyeOcrImageQueryModel : AopObject
    {
        /// <summary>
        /// 用于ocr识别请求图片的BASE64编码
        /// </summary>
        [XmlElement("image")]
        public string Image { get; set; }

        /// <summary>
        /// ocr服务类型，例如银行卡bankcard, 营业执照businesslicense, 车架号carvin, 驾驶证driverlicense, 行驶证vehiclelicense, 身份证idcard, 车牌号vehicleplate, 发票inference等
        /// </summary>
        [XmlElement("ocr_type")]
        public string OcrType { get; set; }

        /// <summary>
        /// 产品集群ID，默认填写示例值
        /// </summary>
        [XmlElement("product_instance_id")]
        public string ProductInstanceId { get; set; }
    }
}
