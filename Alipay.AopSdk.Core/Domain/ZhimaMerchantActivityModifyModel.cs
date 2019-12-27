using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ZhimaMerchantActivityModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantActivityModifyModel : AopObject
    {
        /// <summary>
        /// 对活动的操作类型，合法的操作类型必须在如下枚举中，当前有：  FINISH - 结束活动.
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 活动号，取活动创建接口zhima.credit.pe.promise.activity.create的返回值
        /// </summary>
        [XmlElement("activity_no")]
        public string ActivityNo { get; set; }
    }
}
