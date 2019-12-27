using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ZhimaCreditEpProductCodeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpProductCodeQueryModel : AopObject
    {
        /// <summary>
        /// 二维码唯一标识id
        /// </summary>
        [XmlElement("code_id")]
        public string CodeId { get; set; }

        /// <summary>
        /// 查询结束日期，与开始日期为左闭右闭
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 页码序号，默认从1开始，每页默认为最多300条记录
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 查询开始日期，与结束日期为左闭右闭
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
