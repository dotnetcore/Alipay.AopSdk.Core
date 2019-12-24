using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayMerchantItemFileUploadResponse.
    /// </summary>
    public class AlipayMerchantItemFileUploadResponse : AopResponse
    {
        /// <summary>
        /// 文件在商品中心的素材标识
        /// </summary>
        [XmlElement("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 文件在商品中心的素材标示，创建/更新商品时使用
        /// </summary>
        [XmlElement("material_key")]
        public string MaterialKey { get; set; }
    }
}
