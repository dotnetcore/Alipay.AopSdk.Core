using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// TradePrecreateConfirmIndirectMerchantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TradePrecreateConfirmIndirectMerchantInfo : AopObject
    {
        /// <summary>
        /// 收单机构ID
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 代理收单机构MCC
        /// </summary>
        [XmlElement("agent_mcc")]
        public string AgentMcc { get; set; }

        /// <summary>
        /// 代理收单机构名称
        /// </summary>
        [XmlElement("agent_name")]
        public string AgentName { get; set; }

        /// <summary>
        /// 商户所在的城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 商户所在城市简体中文名
        /// </summary>
        [XmlElement("city_name_sc")]
        public string CityNameSc { get; set; }

        /// <summary>
        /// 间连商户ID（外标）
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 间连商户MCC
        /// </summary>
        [XmlElement("mcc")]
        public string Mcc { get; set; }

        /// <summary>
        /// 商户类型  企业取值：ENTERPRISE  个人取值：  PERSONAL  个体工商户取值：  PERSONAL_BUSINESS
        /// </summary>
        [XmlElement("merchant_type")]
        public string MerchantType { get; set; }

        /// <summary>
        /// 间连商户名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
