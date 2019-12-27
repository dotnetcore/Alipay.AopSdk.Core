using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// IntroductionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IntroductionInfo : AopObject
    {
        /// <summary>
        /// 商品详情-商家介绍图片地址列表
        /// </summary>
        [XmlArray("image_urls")]
        [XmlArrayItem("string")]
        public List<string> ImageUrls { get; set; }

        /// <summary>
        /// 商品详情-商家介绍标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
