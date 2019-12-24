using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayDataDataserviceIcrowdUseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceIcrowdUseModel : AopObject
    {
        /// <summary>
        /// icrowd接口请求参数＋唯一不可空
        /// </summary>
        [XmlElement("icrowd_use_param")]
        public IcrowdUseParam IcrowdUseParam { get; set; }
    }
}
