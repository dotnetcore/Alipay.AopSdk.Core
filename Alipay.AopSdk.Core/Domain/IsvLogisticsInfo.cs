using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// IsvLogisticsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IsvLogisticsInfo : AopObject
    {
        /// <summary>
        /// 快递公司
        /// </summary>
        [XmlElement("express_company")]
        public string ExpressCompany { get; set; }

        /// <summary>
        /// 快递公司运单号
        /// </summary>
        [XmlElement("express_company_bill_no")]
        public string ExpressCompanyBillNo { get; set; }
    }
}
