using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ContentExtInfoModel Data Structure.
    /// </summary>
    [Serializable]
    public class ContentExtInfoModel : AopObject
    {
        /// <summary>
        /// 奖品信息
        /// </summary>
        [XmlArray("prize_info_list")]
        [XmlArrayItem("content_prize_info_model")]
        public List<ContentPrizeInfoModel> PrizeInfoList { get; set; }
    }
}
