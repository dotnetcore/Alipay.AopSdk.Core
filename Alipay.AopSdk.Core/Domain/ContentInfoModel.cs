using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ContentInfoModel Data Structure.
    /// </summary>
    [Serializable]
    public class ContentInfoModel : AopObject
    {
        /// <summary>
        /// 展台
        /// </summary>
        [XmlElement("booth")]
        public string Booth { get; set; }

        /// <summary>
        /// 内容id 加密串
        /// </summary>
        [XmlElement("content_id_str")]
        public string ContentIdStr { get; set; }

        /// <summary>
        /// 扩展信息列表
        /// </summary>
        [XmlElement("ext_info")]
        public ContentExtInfoModel ExtInfo { get; set; }

        /// <summary>
        /// 内容跳转地址
        /// </summary>
        [XmlElement("link_url")]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 内容对应的图片 logo
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 权益领取状态:  noReceive ( 未领取 )   received ( 已领取 )  todayEnded ( 暂时缺货 )   ended ( 已抢光 )   stoped ( 已结束)  notBegin ( 未开始 )
        /// </summary>
        [XmlElement("receive_status")]
        public string ReceiveStatus { get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 内容副标题
        /// </summary>
        [XmlElement("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 内容主标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 阵地
        /// </summary>
        [XmlElement("touch_point")]
        public string TouchPoint { get; set; }
    }
}
