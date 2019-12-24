using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayFundTransGroupfundsUserbillsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransGroupfundsUserbillsQueryModel : AopObject
    {
        /// <summary>
        /// 指定具体活动对应的批次号列表，不超过20个批次
        /// </summary>
        [XmlArray("batch_nos")]
        [XmlArrayItem("string")]
        public List<string> BatchNos { get; set; }

        /// <summary>
        /// 当前用户支付宝账户ID
        /// </summary>
        [XmlElement("current_user_id")]
        public string CurrentUserId { get; set; }
    }
}
