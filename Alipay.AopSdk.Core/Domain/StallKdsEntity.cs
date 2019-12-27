using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// StallKdsEntity Data Structure.
    /// </summary>
    [Serializable]
    public class StallKdsEntity : AopObject
    {
        /// <summary>
        /// 订单来源 枚举 默认all
        /// </summary>
        [XmlElement("dinner_type")]
        public string DinnerType { get; set; }

        /// <summary>
        /// kds id
        /// </summary>
        [XmlElement("kds_id")]
        public string KdsId { get; set; }

        /// <summary>
        /// kds名称
        /// </summary>
        [XmlElement("kds_name")]
        public string KdsName { get; set; }

        /// <summary>
        /// kds类型 ： 制作屏，备餐屏 ， 取餐屏
        /// </summary>
        [XmlElement("kds_type")]
        public string KdsType { get; set; }

        /// <summary>
        /// 0-不打印 ，1-打印 ， 默认 0
        /// </summary>
        [XmlElement("print_flag")]
        public string PrintFlag { get; set; }

        /// <summary>
        /// 打印机 Id
        /// </summary>
        [XmlElement("printer_id")]
        public string PrinterId { get; set; }
    }
}
