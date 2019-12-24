using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MybankCreditLoanapplyQrcodeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoanapplyQrcodeCreateModel : AopObject
    {
        /// <summary>
        /// 银行账户的类型，1 : 对私账户 2：对公账户
        /// </summary>
        [XmlElement("bank_card_category")]
        public string BankCardCategory { get; set; }

        /// <summary>
        /// 收款账户的银行卡卡号
        /// </summary>
        [XmlElement("beneficiary_account")]
        public string BeneficiaryAccount { get; set; }

        /// <summary>
        /// 银行账户的名称
        /// </summary>
        [XmlElement("beneficiary_name")]
        public string BeneficiaryName { get; set; }

        /// <summary>
        /// 支行名称
        /// </summary>
        [XmlElement("deposit_bank")]
        public string DepositBank { get; set; }

        /// <summary>
        /// 开户行的联行号
        /// </summary>
        [XmlElement("deposit_bank_cnaps_code")]
        public string DepositBankCnapsCode { get; set; }

        /// <summary>
        /// 总行联行号
        /// </summary>
        [XmlElement("head_bank_cnaps_code")]
        public string HeadBankCnapsCode { get; set; }

        /// <summary>
        /// 二维码失效的时间
        /// </summary>
        [XmlElement("invalid_date")]
        public string InvalidDate { get; set; }

        /// <summary>
        /// 订单金额字符串，必须为整数（单位：元）
        /// </summary>
        [XmlElement("order_amt")]
        public string OrderAmt { get; set; }

        /// <summary>
        /// 调用方生成的订单编号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
