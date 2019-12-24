using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipaySocialAntforestProjectQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialAntforestProjectQueryModel : AopObject
    {
        /// <summary>
        /// 请求类型，不同类型查询的树项目可能不同，默认可不选择，由运营同学进行项目的绑定操作
        /// </summary>
        [XmlElement("query_type")]
        public string QueryType { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID，执行该查询操作的支付宝用户
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
