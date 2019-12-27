using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// SceneDrawdownDetail Data Structure.
    /// </summary>
    [Serializable]
    public class SceneDrawdownDetail : AopObject
    {
        /// <summary>
        /// 网商支用号
        /// </summary>
        [XmlElement("drawdown_no")]
        public string DrawdownNo { get; set; }

        /// <summary>
        /// 资方借据号
        /// </summary>
        [XmlElement("fin_drawdown_no")]
        public string FinDrawdownNo { get; set; }
    }
}
