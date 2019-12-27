using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntfortuneEquityInstpointPrizeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneEquityInstpointPrizeQueryModel : AopObject
    {
        /// <summary>
        /// 当前页数，取值[1,50]整数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页大小，取值[1,20]整数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
