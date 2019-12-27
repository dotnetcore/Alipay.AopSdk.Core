using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// CategoryRiskInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CategoryRiskInfo : AopObject
    {
        /// <summary>
        /// 风控类目code，为必传字段
        /// </summary>
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 风控类目名称
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 消费笔数上线。代表一个顾客在所有与芝麻信用合作的商户中，可同时享受该产品类信用服务的订单数量，推荐值为2，最多不超过5。
        /// </summary>
        [XmlElement("global_orders_limit_number")]
        public long GlobalOrdersLimitNumber { get; set; }

        /// <summary>
        /// 全局限额开关，可取值true和false。关闭后，当顾客在所有与芝麻信用合作的商户中，未结束的订单减免金额总额即便达到拦截阈值时，也可继续享受信用服务。
        /// </summary>
        [XmlElement("global_quota_switch")]
        public bool GlobalQuotaSwitch { get; set; }

        /// <summary>
        /// 额度部分免开关，可取值true和false。 关闭后，当顾客的可免额度小于所需费用时，顾客不可使用可免额度，需全部用资金支付。
        /// </summary>
        [XmlElement("part_deposit_switch")]
        public bool PartDepositSwitch { get; set; }

        /// <summary>
        /// 综合风险评估，可取值：A1(高准入，满足芝麻分的情况下，通过率在90%以上)；A2(中准入，满足芝麻分情况下，通过率在80%以上)；A3(低准入，满足芝麻分情况下，通过率在60%以上)。
        /// </summary>
        [XmlElement("risk_policy")]
        public string RiskPolicy { get; set; }

        /// <summary>
        /// 芝麻分准入门槛。低于服务使用门槛的消费者将不能使用该品类的服务，推荐填写550分，建议填写范围550~850。
        /// </summary>
        [XmlElement("score")]
        public long Score { get; set; }
    }
}
