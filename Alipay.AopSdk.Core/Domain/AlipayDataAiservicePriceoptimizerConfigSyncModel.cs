using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayDataAiservicePriceoptimizerConfigSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataAiservicePriceoptimizerConfigSyncModel : AopObject
    {
        /// <summary>
        /// 内部接口版本号
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 事件发生时间
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 操作的内容，存json； 接入方需要沟通具体传入的参数和对应的含义，并以key-value格式传入。
        /// </summary>
        [XmlElement("op_content")]
        public string OpContent { get; set; }

        /// <summary>
        /// 操作类型,如 config_modify:修改配置
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 产品类型，如 online_car:网约车 card50:50元储值卡
        /// </summary>
        [XmlElement("product_type")]
        public string ProductType { get; set; }

        /// <summary>
        /// 标识业务场景 single_pay:单次支付定价  stored_value_card:储值卡
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 接入方名称,不同业务方的区分
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 渠道 alipay_tinyapp:支付宝小程序 app:app客户端
        /// </summary>
        [XmlElement("trade_channel")]
        public string TradeChannel { get; set; }
    }
}
