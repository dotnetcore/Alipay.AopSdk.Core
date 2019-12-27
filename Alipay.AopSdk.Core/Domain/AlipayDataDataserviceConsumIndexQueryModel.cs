using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayDataDataserviceConsumIndexQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceConsumIndexQueryModel : AopObject
    {
        /// <summary>
        /// 区域编码，多个编码的时候用英文逗号分割，最多不超过20个
        /// </summary>
        [XmlElement("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 区域类型，枚举值：city(城市)、county(区县)、town(街道)、trading(商圈)
        /// </summary>
        [XmlElement("area_type")]
        public string AreaType { get; set; }

        /// <summary>
        /// 分类，枚举值：all(无限定)、wd(工作日)、hd(节假日)、医疗教育、商场超市、服饰珠宝、酒店及住宿相关、餐饮、出行服务
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 数据类型，枚举值：consum(消费指数)、people(消费满足度指数)、saturation(消费饱和度指数)
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 查询日期，最早为前6个月，例如如当前为201907，则此参数最早可为201901。
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }
    }
}
