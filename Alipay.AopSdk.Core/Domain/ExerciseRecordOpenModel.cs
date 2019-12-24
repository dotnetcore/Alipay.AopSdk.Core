using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ExerciseRecordOpenModel Data Structure.
    /// </summary>
    [Serializable]
    public class ExerciseRecordOpenModel : AopObject
    {
        /// <summary>
        /// 运动计划类型。枚举：运动项目(ITEM),或课程(COURSE)
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 课程列表。当biz_type=COURSE时必填
        /// </summary>
        [XmlElement("course_list")]
        public ExerciseCourseOpenModel CourseList { get; set; }

        /// <summary>
        /// 单日进度汇总列表
        /// </summary>
        [XmlArray("daily_summary")]
        [XmlArrayItem("exercise_daily_summary_open_model")]
        public List<ExerciseDailySummaryOpenModel> DailySummary { get; set; }

        /// <summary>
        /// 一级健身项目列表。当biz_type=ITEM时必填
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("exercise_item_open_model")]
        public List<ExerciseItemOpenModel> ItemList { get; set; }

        /// <summary>
        /// 运动建议列表
        /// </summary>
        [XmlArray("proposal_list")]
        [XmlArrayItem("string")]
        public List<string> ProposalList { get; set; }

        /// <summary>
        /// 时间维度类型。健身日志只支持终生类型。枚举：LIFE("终生")
        /// </summary>
        [XmlElement("time_dimension_type")]
        public string TimeDimensionType { get; set; }

        /// <summary>
        /// 维度所所对应的值。LIFE时为yyyy-MM-dd格式的日期。日志同步接口只支持传一个时间维度值
        /// </summary>
        [XmlElement("values")]
        public string Values { get; set; }
    }
}
