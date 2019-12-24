using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// NoticeTemplateArgs Data Structure.
    /// </summary>
    [Serializable]
    public class NoticeTemplateArgs : AopObject
    {
        /// <summary>
        /// 课程开始时间
        /// </summary>
        [XmlElement("course_start_time")]
        public string CourseStartTime { get; set; }
    }
}
