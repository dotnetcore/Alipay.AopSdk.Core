using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// TaxBillContent Data Structure.
    /// </summary>
    [Serializable]
    public class TaxBillContent : AopObject
    {
        /// <summary>
        /// 校验码
        /// </summary>
        [XmlElement("anti_fake_code")]
        public string AntiFakeCode { get; set; }

        /// <summary>
        /// 复审
        /// </summary>
        [XmlElement("checker")]
        public string Checker { get; set; }

        /// <summary>
        /// 开票人
        /// </summary>
        [XmlElement("clerk")]
        public string Clerk { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        [XmlElement("einv_amount")]
        public string EinvAmount { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [XmlElement("einv_code")]
        public string EinvCode { get; set; }

        /// <summary>
        /// 开票日期
        /// </summary>
        [XmlElement("einv_date")]
        public string EinvDate { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [XmlElement("einv_no")]
        public string EinvNo { get; set; }

        /// <summary>
        /// 收款人
        /// </summary>
        [XmlElement("payee")]
        public string Payee { get; set; }

        /// <summary>
        /// 卖方地址、电话
        /// </summary>
        [XmlElement("payee_address")]
        public string PayeeAddress { get; set; }

        /// <summary>
        /// 卖方开户行
        /// </summary>
        [XmlElement("payee_bank_name")]
        public string PayeeBankName { get; set; }

        /// <summary>
        /// 卖方名称
        /// </summary>
        [XmlElement("payee_name")]
        public string PayeeName { get; set; }

        /// <summary>
        /// 卖方纳税人识别号
        /// </summary>
        [XmlElement("payee_register_no")]
        public string PayeeRegisterNo { get; set; }

        /// <summary>
        /// 买方地址、电话
        /// </summary>
        [XmlElement("payer_address")]
        public string PayerAddress { get; set; }

        /// <summary>
        /// 买方开户行
        /// </summary>
        [XmlElement("payer_bank_name")]
        public string PayerBankName { get; set; }

        /// <summary>
        /// 买方名称
        /// </summary>
        [XmlElement("payer_name")]
        public string PayerName { get; set; }

        /// <summary>
        /// 买方纳税人识别号
        /// </summary>
        [XmlElement("payer_register_no")]
        public string PayerRegisterNo { get; set; }

        /// <summary>
        /// 价税合计（大写）
        /// </summary>
        [XmlElement("sum_amount")]
        public string SumAmount { get; set; }

        /// <summary>
        /// 税额
        /// </summary>
        [XmlElement("tax_amount")]
        public string TaxAmount { get; set; }

        /// <summary>
        /// 不含税金额
        /// </summary>
        [XmlElement("without_tax_amount")]
        public string WithoutTaxAmount { get; set; }
    }
}
