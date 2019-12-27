using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayCommerceTransportAdStocktaskresultQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportAdStocktaskresultQueryModel : AopObject
    {
        /// <summary>
        /// 广告主id + 库存结果查询前校验该任务是否属于该广告主
        /// </summary>
        [XmlElement("ad_user_id")]
        public long AdUserId { get; set; }

        /// <summary>
        /// 库存查询任务id + 根据库存查询任务id获得库存结果
        /// </summary>
        [XmlElement("task_id")]
        public long TaskId { get; set; }
    }
}
