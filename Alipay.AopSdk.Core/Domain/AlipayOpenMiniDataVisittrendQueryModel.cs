using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniDataVisittrendQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniDataVisittrendQueryModel : AopObject
    {
        /// <summary>
        /// 查询小程序访问趋势数据的粒度，如HOUR-小时级
        /// </summary>
        [XmlElement("time_unit")]
        public string TimeUnit { get; set; }
    }
}
