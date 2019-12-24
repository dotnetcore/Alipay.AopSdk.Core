using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayAccountFinriskMarkriskDatafactorQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountFinriskMarkriskDatafactorQueryModel : AopObject
    {
        /// <summary>
        /// Json格式表示市场风险损益计算入参
        /// </summary>
        [XmlElement("data_factor_build_req")]
        public string DataFactorBuildReq { get; set; }
    }
}
