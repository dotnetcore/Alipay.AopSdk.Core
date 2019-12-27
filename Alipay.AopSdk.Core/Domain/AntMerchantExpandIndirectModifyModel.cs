using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntMerchantExpandIndirectModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandIndirectModifyModel : AopObject
    {
        /// <summary>
        /// 商户地址信息
        /// </summary>
        [XmlArray("address_info")]
        [XmlArrayItem("address_info")]
        public List<AddressInfo> AddressInfo { get; set; }

        /// <summary>
        /// 商户简称
        /// </summary>
        [XmlElement("alias_name")]
        public string AliasName { get; set; }

        /// <summary>
        /// 商户对应银行所开立的结算卡信息
        /// </summary>
        [XmlArray("bankcard_info")]
        [XmlArrayItem("bank_card_info")]
        public List<BankCardInfo> BankcardInfo { get; set; }

        /// <summary>
        /// 商户证件编号（企业或者个体工商户提供营业执照，事业单位提供事证号）
        /// </summary>
        [XmlElement("business_license")]
        public string BusinessLicense { get; set; }

        /// <summary>
        /// 商户证件类型，取值范围：NATIONAL_LEGAL：营业执照；NATIONAL_LEGAL_MERGE:营业执照(多证合一)；INST_RGST_CTF：事业单位法人证书
        /// </summary>
        [XmlElement("business_license_type")]
        public string BusinessLicenseType { get; set; }

        /// <summary>
        /// 商户经营类目，参考文档：https://doc.open.alipay.com/doc2/detail?&docType=1&articleId=105444，非银联网联调用时必传
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 商户负责人信息
        /// </summary>
        [XmlArray("contact_info")]
        [XmlArrayItem("contact_info")]
        public List<ContactInfo> ContactInfo { get; set; }

        /// <summary>
        /// 商户编号，由机构定义，需要保证在机构下唯一，与sub_merchant_id二选一
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 受理商户的支付宝账号（用于关联商户生活号、原服务窗，打通口碑营销活动）
        /// </summary>
        [XmlArray("logon_id")]
        [XmlArrayItem("string")]
        public List<string> LogonId { get; set; }

        /// <summary>
        /// 标准商户类别码，例如5976表示“专业销售-药品医疗-康复和身体辅助用品”，银联网联调用时必传
        /// </summary>
        [XmlElement("mcc")]
        public string Mcc { get; set; }

        /// <summary>
        /// 商户备注信息，可填写额外信息
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 签约机构pid。银联或者网联调用时，如果未传sub_merchant_id,则需要同时传org_pid和externel_id。
        /// </summary>
        [XmlElement("org_pid")]
        public string OrgPid { get; set; }

        /// <summary>
        /// 受理商户的固定二维码链接地址（即一码多付页面地址，用于后续支付宝营销活动）  商户所属的银行或ISV 给商户的二维码url值  一码多付方案:https://doc.open.alipay.com/docs/doc.htm?&docType=1&articleId=105672
        /// </summary>
        [XmlArray("pay_code_info")]
        [XmlArrayItem("string")]
        public List<string> PayCodeInfo { get; set; }

        /// <summary>
        /// 申请服务，不传默认申请当面付服务。  允许同时申请多个服务，各服务的准入验证相互独立，服务申请实时生效；若已生效服务不在本次申请的服务列表中，会取消当前生效服务;当前可用服务请关注出参service_codes字段。</br>  目前支持三种类型</br>  PC：网站支付</br>  APP：无线支付</br>  F2F：当面付</br>  </br>  PC和APP对应线上，F2F对应线下。
        /// </summary>
        [XmlArray("service_codes")]
        [XmlArrayItem("string")]
        public List<string> ServiceCodes { get; set; }

        /// <summary>
        /// 商户客服电话
        /// </summary>
        [XmlElement("service_phone")]
        public string ServicePhone { get; set; }

        /// <summary>
        /// 仅支持网站、APP信息，site_type必传  网站必传site_url，APP必传site_name。
        /// </summary>
        [XmlArray("site_info")]
        [XmlArrayItem("site_info")]
        public List<SiteInfo> SiteInfo { get; set; }

        /// <summary>
        /// 间连受理商户的推荐组织。如果是银行自有商户入驻，则推荐组织为银行，如果是ISV推广的商户，那么商户推荐组织为ISV，如果是第三方支付机构的自有商户，则推荐组织为第三方支付机构。
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 商户在支付宝入驻成功后，生成的支付宝内全局唯一的商户编号，与external_id二选一
        /// </summary>
        [XmlElement("sub_merchant_id")]
        public string SubMerchantId { get; set; }
    }
}
