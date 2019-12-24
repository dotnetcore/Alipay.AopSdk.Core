using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipaySocialAntforestAccountTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialAntforestAccountTransferModel : AopObject
    {
        /// <summary>
        /// 用户在森林里的账户id，转移能量的源头账户（可以是user_id相同）
        /// </summary>
        [XmlElement("energy_account_from")]
        public string EnergyAccountFrom { get; set; }

        /// <summary>
        /// 能量转移的目标账户
        /// </summary>
        [XmlElement("energy_account_to")]
        public string EnergyAccountTo { get; set; }

        /// <summary>
        /// 转移出去的能量值
        /// </summary>
        [XmlElement("energy_count")]
        public long EnergyCount { get; set; }

        /// <summary>
        /// 扩展字段，用于不同业务之间的数据扩展
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 比如某种业务标准外部订单号,比如交易外部订单号，代表商户端自己订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// USER_TO_ACCOUNT： 内部户->外部户转移，钉钉用这个类型
        /// </summary>
        [XmlElement("transfer_type")]
        public string TransferType { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID，执行该操作的支付宝用户
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
