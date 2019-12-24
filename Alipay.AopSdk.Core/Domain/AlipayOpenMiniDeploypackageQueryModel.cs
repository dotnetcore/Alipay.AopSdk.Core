using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniDeploypackageQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniDeploypackageQueryModel : AopObject
    {
        /// <summary>
        /// 端标识
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 客户端层面的渠道：CHANNEL_OFFICIAL 正式包  CHANNEL_RC 灰度包
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 客户端版本
        /// </summary>
        [XmlElement("client")]
        public string Client { get; set; }

        /// <summary>
        /// 设备号
        /// </summary>
        [XmlElement("diu")]
        public string Diu { get; set; }

        /// <summary>
        /// 环境：prepub 预发、线上 production）
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }

        /// <summary>
        /// 本地已存在的包信息
        /// </summary>
        [XmlElement("existed")]
        public string Existed { get; set; }

        /// <summary>
        /// 灰度规则
        /// </summary>
        [XmlElement("gray_rules")]
        public string GrayRules { get; set; }

        /// <summary>
        /// 只在应用应用互保,本地应用版本信息
        /// </summary>
        [XmlElement("local_app_info")]
        public string LocalAppInfo { get; set; }

        /// <summary>
        /// 平台标识
        /// </summary>
        [XmlElement("platform")]
        public string Platform { get; set; }

        /// <summary>
        /// 是否开启互保
        /// </summary>
        [XmlElement("prefer_local")]
        public string PreferLocal { get; set; }

        /// <summary>
        /// 协议版本号
        /// </summary>
        [XmlElement("protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// 拉包请求的数据
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// 请求同步/异步标识
        /// </summary>
        [XmlElement("req_mode")]
        public string ReqMode { get; set; }

        /// <summary>
        /// 客户端sdk版本号,一般输出给多端使用
        /// </summary>
        [XmlElement("sdk")]
        public string Sdk { get; set; }

        /// <summary>
        /// 是否开启强大的RPC功能
        /// </summary>
        [XmlElement("stable_rpc")]
        public string StableRpc { get; set; }

        /// <summary>
        /// 系统版本号
        /// </summary>
        [XmlElement("system")]
        public string System { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
