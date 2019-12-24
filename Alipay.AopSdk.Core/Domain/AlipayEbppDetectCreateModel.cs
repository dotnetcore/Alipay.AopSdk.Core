using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEbppDetectCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppDetectCreateModel : AopObject
    {
        /// <summary>
        /// 业务类型。巡检平台统一分配。
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 数据来源（一般为系统名称）
        /// </summary>
        [XmlElement("data_from_type")]
        public string DataFromType { get; set; }

        /// <summary>
        /// 外部业务标识
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 检测项列表。支持对链接url、纯文本、图片进行检测。
        /// </summary>
        [XmlArray("service_list")]
        [XmlArrayItem("detect_service_entity")]
        public List<DetectServiceEntity> ServiceList { get; set; }
    }
}
