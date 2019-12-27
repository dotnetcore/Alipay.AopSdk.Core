using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// CreditPayInstallmentAssetVO Data Structure.
    /// </summary>
    [Serializable]
    public class CreditPayInstallmentAssetVO : AopObject
    {
        /// <summary>
        /// 信用支付资产详情基础信息
        /// </summary>
        [XmlElement("base_info")]
        public CreditPayAssetBaseVO BaseInfo { get; set; }

        /// <summary>
        /// 分期详情
        /// </summary>
        [XmlArray("installment_details")]
        [XmlArrayItem("credit_pay_installment_detail_v_o")]
        public List<CreditPayInstallmentDetailVO> InstallmentDetails { get; set; }
    }
}
