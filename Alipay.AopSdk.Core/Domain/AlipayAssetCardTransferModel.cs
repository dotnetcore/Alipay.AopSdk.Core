using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayAssetCardTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAssetCardTransferModel : AopObject
    {
        /// <summary>
        /// 转移金额，单位元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 模板实例，资产id
        /// </summary>
        [XmlElement("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 资产平台类型卡/券
        /// </summary>
        [XmlElement("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// 业务发生时间
        /// </summary>
        [XmlElement("biz_dt")]
        public string BizDt { get; set; }

        /// <summary>
        /// 业务订单号，幂等字段
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 资金流场景
        /// </summary>
        [XmlElement("fund_scence")]
        public string FundScence { get; set; }

        /// <summary>
        /// 接收方支付宝用户id
        /// </summary>
        [XmlElement("receive_user_id")]
        public string ReceiveUserId { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 支付宝用户userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
