using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// SceneExtParam Data Structure.
    /// </summary>
    [Serializable]
    public class SceneExtParam : AopObject
    {
        /// <summary>
        /// B流程申请准入原因
        /// </summary>
        [XmlElement("apply_reason")]
        public string ApplyReason { get; set; }

        /// <summary>
        /// 机构的合约编号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 贴息金额，单位：分
        /// </summary>
        [XmlElement("discountamt")]
        public string Discountamt { get; set; }

        /// <summary>
        /// 首付款，单位：分
        /// </summary>
        [XmlElement("firstpayamt")]
        public string Firstpayamt { get; set; }

        /// <summary>
        /// 利率，xx%格式
        /// </summary>
        [XmlElement("interestrate")]
        public string Interestrate { get; set; }

        /// <summary>
        /// 尾款，单位：分
        /// </summary>
        [XmlElement("lastpayamt")]
        public string Lastpayamt { get; set; }

        /// <summary>
        /// 月供，单位：分，需要大于等于0
        /// </summary>
        [XmlElement("monthpayamt")]
        public string Monthpayamt { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }
    }
}
