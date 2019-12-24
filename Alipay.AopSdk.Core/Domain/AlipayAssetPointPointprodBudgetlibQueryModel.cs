using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayAssetPointPointprodBudgetlibQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAssetPointPointprodBudgetlibQueryModel : AopObject
    {
        /// <summary>
        /// 预算库编码
        /// </summary>
        [XmlElement("budget_code")]
        public string BudgetCode { get; set; }
    }
}
