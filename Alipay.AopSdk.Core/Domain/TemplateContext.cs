using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// TemplateContext Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateContext : AopObject
    {
        /// <summary>
        /// 底部链接描述文字，如“查看详情”，最多能传8个汉字或16个英文字符，长度超出会报错
        /// </summary>
        [XmlElement("action_name")]
        public string ActionName { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 模板的标题。  如：您好，您已成功预约车辆。
        /// </summary>
        [XmlElement("first")]
        public TemplateKeyword First { get; set; }

        /// <summary>
        /// 顶部色条的色值
        /// </summary>
        [XmlElement("head_color")]
        public string HeadColor { get; set; }

        /// <summary>
        /// 消息备注。 如：请您及时到达修理厂哦！
        /// </summary>
        [XmlElement("remark")]
        public TemplateKeyword Remark { get; set; }

        /// <summary>
        /// 点击消息后承接页的地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
