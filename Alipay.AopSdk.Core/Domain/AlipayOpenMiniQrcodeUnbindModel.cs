using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniQrcodeUnbindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniQrcodeUnbindModel : AopObject
    {
        /// <summary>
        /// 路由规则组，用于唯一标记一条路由规则
        /// </summary>
        [XmlElement("route_group")]
        public string RouteGroup { get; set; }
    }
}
