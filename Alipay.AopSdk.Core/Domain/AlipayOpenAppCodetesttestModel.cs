using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenAppCodetesttestModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppCodetesttestModel : AopObject
    {
        /// <summary>
        /// 测试参数1
        /// </summary>
        [XmlElement("testparam")]
        public string Testparam { get; set; }

        /// <summary>
        /// 测试测试
        /// </summary>
        [XmlElement("testtestparam")]
        public string Testtestparam { get; set; }
    }
}
