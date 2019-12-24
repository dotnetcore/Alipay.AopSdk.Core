using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvPicvideoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogMmtcaftscvPicvideoQueryModel : AopObject
    {
        /// <summary>
        /// 请求Id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 交易Id
        /// </summary>
        [XmlElement("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// 捞取类型: images, videos, video_info
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 只对videos类型有效, 例：  {"layers": "0", "segments": "0"}  {"layers": "1,2,3,4,5", "segments": "1,2"}  注：layers 为 "0"为全部层，segments 为 "0"为全部 段
        /// </summary>
        [XmlElement("video_detail")]
        public string VideoDetail { get; set; }
    }
}
