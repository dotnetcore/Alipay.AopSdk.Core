using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ExerciseCourseOpenModel Data Structure.
    /// </summary>
    [Serializable]
    public class ExerciseCourseOpenModel : AopObject
    {
        /// <summary>
        /// 课程类型：团课(CLASS),私教(PRIVATE_LESSON)
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 上课教室名
        /// </summary>
        [XmlElement("classroom")]
        public string Classroom { get; set; }

        /// <summary>
        /// 课程详情链接（订单链接）
        /// </summary>
        [XmlElement("course_detail_url")]
        public string CourseDetailUrl { get; set; }

        /// <summary>
        /// 教练的手艺人ID
        /// </summary>
        [XmlElement("craftsman_id")]
        public string CraftsmanId { get; set; }

        /// <summary>
        /// 教练昵称
        /// </summary>
        [XmlElement("craftsman_name")]
        public string CraftsmanName { get; set; }

        /// <summary>
        /// 教练头衔
        /// </summary>
        [XmlElement("craftsman_title")]
        public string CraftsmanTitle { get; set; }

        /// <summary>
        /// 课程结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 外部课程ID。课程记录在ISV系统中的ID
        /// </summary>
        [XmlElement("external_course_id")]
        public string ExternalCourseId { get; set; }

        /// <summary>
        /// 课程名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 来源类型。默认SIGN_UP。枚举：报名（SIGN_UP）,推荐（RECOMMEND）
        /// </summary>
        [XmlElement("source_type")]
        public string SourceType { get; set; }

        /// <summary>
        /// 课程开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
