using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipaySecurityRiskHufuAuthQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskHufuAuthQueryModel : AopObject
    {
        /// <summary>
        /// 获取虎符结果需要的code
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 获取虎符结果的额外策略信息
        /// </summary>
        [XmlElement("policy")]
        public string Policy { get; set; }

        /// <summary>
        /// 业务系统创建虎符时传入的序列号
        /// </summary>
        [XmlElement("serial")]
        public string Serial { get; set; }
    }
}
