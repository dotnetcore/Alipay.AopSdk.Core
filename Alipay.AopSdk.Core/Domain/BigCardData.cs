using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// BigCardData Data Structure.
    /// </summary>
    [Serializable]
    public class BigCardData : AopObject
    {
        /// <summary>
        /// 主文本行动点文案，在卡片的button处展现
        /// </summary>
        [XmlElement("action_text")]
        public string ActionText { get; set; }

        /// <summary>
        /// 主文本信息文案，如XXXX元，XXXX积分
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 主文本副文案，在主文本的下方作为补充说明
        /// </summary>
        [XmlElement("biz_title")]
        public string BizTitle { get; set; }

        /// <summary>
        /// 主文本字体颜色（如12545元）
        /// </summary>
        [XmlElement("color")]
        public string Color { get; set; }

        /// <summary>
        /// 卡片的图链接， 1 图 400x400 (3x)， toolType 2 图 450x249 (3x) 或 300x166 (2x)，图片体积要求 50k 以内
        /// </summary>
        [XmlElement("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 左侧行动点图片链接，对应leftAction里面的imageUrl字段
        /// </summary>
        [XmlElement("left_image_url")]
        public string LeftImageUrl { get; set; }

        /// <summary>
        /// 左侧行动点链接，对应leftAction的targetUrl字段
        /// </summary>
        [XmlElement("left_target_url")]
        public string LeftTargetUrl { get; set; }

        /// <summary>
        /// 左侧行动点文案，对应leftAction里面的title字段
        /// </summary>
        [XmlElement("left_title")]
        public string LeftTitle { get; set; }

        /// <summary>
        /// 右侧行动点图片链接，对应rightAction里面的imageUrl字段
        /// </summary>
        [XmlElement("right_image_url")]
        public string RightImageUrl { get; set; }

        /// <summary>
        /// 右侧行动点链接，对应rightAction的targetUrl字段
        /// </summary>
        [XmlElement("right_target_url")]
        public string RightTargetUrl { get; set; }

        /// <summary>
        /// 右侧行动点文案，对应rightAction里面的title字段
        /// </summary>
        [XmlElement("right_title")]
        public string RightTitle { get; set; }

        /// <summary>
        /// 支付宝卡片副标题文字内容
        /// </summary>
        [XmlElement("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 主文本行动点跳转链接
        /// </summary>
        [XmlElement("target_url")]
        public string TargetUrl { get; set; }

        /// <summary>
        /// 卡片类型，目前只会传1或2，标识工具类的类型1和类型2
        /// </summary>
        [XmlElement("tool_type")]
        public long ToolType { get; set; }
    }
}
