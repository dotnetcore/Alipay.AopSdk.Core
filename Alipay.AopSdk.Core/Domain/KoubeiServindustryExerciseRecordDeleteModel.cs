using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiServindustryExerciseRecordDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiServindustryExerciseRecordDeleteModel : AopObject
    {
        /// <summary>
        /// 运动计划类型。枚举：运动项目(ITEM),或课程(COURSE),单次记录(ITEM_SINGLE)
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 健身用户id
        /// </summary>
        [XmlElement("fitness_id")]
        public string FitnessId { get; set; }

        /// <summary>
        /// 操作类型，DELETE_CRITERIA=删除符合条件记录,DELETE_SHOP=删除用户该门店下记录
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 外部请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 时间维度类型。枚举：DAY("日"),WEEK("周"),MONTH("月"),LIFE("终生")
        /// </summary>
        [XmlElement("time_dimension_type")]
        public string TimeDimensionType { get; set; }

        /// <summary>
        /// 维度所对应的值
        /// </summary>
        [XmlElement("values")]
        public string Values { get; set; }
    }
}
