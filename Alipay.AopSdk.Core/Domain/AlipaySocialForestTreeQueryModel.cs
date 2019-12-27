using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipaySocialForestTreeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialForestTreeQueryModel : AopObject
    {
        /// <summary>
        /// 种树截止时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 种树开始时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID。目前该参数服务端没有用
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
