using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ViewStyleInfoModel Data Structure.
    /// </summary>
    [Serializable]
    public class ViewStyleInfoModel : AopObject
    {
        /// <summary>
        /// 背景色
        /// </summary>
        [XmlElement("bg_color")]
        public string BgColor { get; set; }

        /// <summary>
        /// 背景图片Id，通过接口（alipay.offline.material.image.upload）上传图片   图片说明：2M以内，格式：bmp、png、jpeg、jpg、gif；   尺寸不小于1020*643px；   图片不得有圆角，不得拉伸变形
        /// </summary>
        [XmlElement("bg_img")]
        public string BgImg { get; set; }

        /// <summary>
        /// 品牌商名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// logo的图片ID，通过接口（alipay.offline.material.image.upload）上传图片   图片说明：1M以内，格式bmp、png、jpeg、jpg、gif；   尺寸不小于500*500px的正方形；   请优先使用商家LOGO；
        /// </summary>
        [XmlElement("logo_img")]
        public string LogoImg { get; set; }
    }
}
