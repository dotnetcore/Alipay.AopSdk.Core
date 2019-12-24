using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayAssetCardDisburseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAssetCardDisburseModel : AopObject
    {
        /// <summary>
        /// 打款金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 支付宝资产id,跟模板id二选一
        /// </summary>
        [XmlElement("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 资产平台类型卡/券
        /// </summary>
        [XmlElement("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// 业务时间
        /// </summary>
        [XmlElement("biz_dt")]
        public string BizDt { get; set; }

        /// <summary>
        /// 业务订单号，幂等用
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 扩展信息  账单信息key:merchantBillInfo
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 资金流场景
        /// </summary>
        [XmlElement("fund_scence")]
        public string FundScence { get; set; }

        /// <summary>
        /// 收款方支付宝用户id
        /// </summary>
        [XmlElement("payee_user_id")]
        public string PayeeUserId { get; set; }

        /// <summary>
        /// 付款方支付宝用户id
        /// </summary>
        [XmlElement("payer_user_id")]
        public string PayerUserId { get; set; }

        /// <summary>
        /// 支付宝模板id,跟资产id二选一
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
