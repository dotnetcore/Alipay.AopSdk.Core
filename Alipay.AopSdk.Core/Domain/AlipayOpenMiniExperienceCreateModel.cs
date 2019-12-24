using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniExperienceCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniExperienceCreateModel : AopObject
    {
        /// <summary>
        /// 小程序版本号
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 小程序客户端类型，默认为支付宝端。支付宝端：com.alipay.alipaywallet,DINGDING端：com.alibaba.android.rimet,高德端:com.amap.app,天猫精灵端:com.alibaba.ailabs.genie.webapps,支付宝IOT:com.alipay.iot.xpaas
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }
    }
}
