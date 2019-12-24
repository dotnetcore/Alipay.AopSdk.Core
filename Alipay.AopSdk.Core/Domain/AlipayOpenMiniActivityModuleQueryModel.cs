using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniActivityModuleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniActivityModuleQueryModel : AopObject
    {
        /// <summary>
        /// 地区码，比如杭州的城市码是300100
        /// </summary>
        [XmlElement("lbs_code")]
        public string LbsCode { get; set; }

        /// <summary>
        /// 模块编码，模块的唯一标识，可根据该编码查询模块数据信息
        /// </summary>
        [XmlElement("module_code")]
        public string ModuleCode { get; set; }

        /// <summary>
        /// 页码，代表请求的是第几页的数据
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页数量，代表每页请求的数据的数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
