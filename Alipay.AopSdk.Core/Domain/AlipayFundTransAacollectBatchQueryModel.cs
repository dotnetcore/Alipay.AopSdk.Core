using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayFundTransAacollectBatchQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransAacollectBatchQueryModel : AopObject
    {
        /// <summary>
        /// 批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 防止接口被遍历所设置的查询token，在调用创建批次时生成，随批次号下发
        /// </summary>
        [XmlElement("batch_token")]
        public string BatchToken { get; set; }
    }
}
