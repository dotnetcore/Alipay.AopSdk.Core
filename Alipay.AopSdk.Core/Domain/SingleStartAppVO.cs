using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// SingleStartAppVO Data Structure.
    /// </summary>
    [Serializable]
    public class SingleStartAppVO : AopObject
    {
        /// <summary>
        /// 小程序启动协议
        /// </summary>
        [XmlElement("protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// 按照标准定义的startAppModel
        /// </summary>
        [XmlElement("start_app_model")]
        public string StartAppModel { get; set; }
    }
}
