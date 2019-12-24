using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayCommerceIotDeviceAudioDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotDeviceAudioDeleteModel : AopObject
    {
        /// <summary>
        /// 语音id, 也就是语音合成接口返回的audio_id
        /// </summary>
        [XmlElement("audio_id")]
        public string AudioId { get; set; }

        /// <summary>
        /// 设备的唯一标识,设备id
        /// </summary>
        [XmlElement("biz_tid")]
        public string BizTid { get; set; }
    }
}
