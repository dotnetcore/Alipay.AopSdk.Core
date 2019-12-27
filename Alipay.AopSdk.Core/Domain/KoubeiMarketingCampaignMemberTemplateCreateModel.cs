using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignMemberTemplateCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignMemberTemplateCreateModel : AopObject
    {
        /// <summary>
        /// 会员模板支持的端信息，  目前有两种koubei,wechat，  默认支持koubei端
        /// </summary>
        [XmlArray("client_channels")]
        [XmlArrayItem("string")]
        public List<string> ClientChannels { get; set; }

        /// <summary>
        /// 会员模板的描述信息
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 卡行动点配置；   行动点，即用户可点击跳转的区块，类似按钮控件的交互；   最多定制4个行动点。
        /// </summary>
        [XmlArray("member_actions")]
        [XmlArrayItem("member_action_model")]
        public List<MemberActionModel> MemberActions { get; set; }

        /// <summary>
        /// 会员资产
        /// </summary>
        [XmlArray("member_assets")]
        [XmlArrayItem("member_asset_model")]
        public List<MemberAssetModel> MemberAssets { get; set; }

        /// <summary>
        /// 权益信息，在卡包的卡详情页面会自动添加权益栏位，展现会员卡特权
        /// </summary>
        [XmlArray("member_benefits")]
        [XmlArrayItem("member_benefit_model")]
        public List<MemberBenefitModel> MemberBenefits { get; set; }

        /// <summary>
        /// 会员模板下的等级列表
        /// </summary>
        [XmlArray("member_levels")]
        [XmlArrayItem("member_level_model")]
        public List<MemberLevelModel> MemberLevels { get; set; }

        /// <summary>
        /// 用户领卡配置，在门店等渠道露出领卡入口时，需要部署的商户领卡H5页面地址
        /// </summary>
        [XmlElement("member_open_info")]
        public MemberOpenInfoModel MemberOpenInfo { get; set; }

        /// <summary>
        /// 会员模板名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 外部会员模板号
        /// </summary>
        [XmlElement("out_template_id")]
        public string OutTemplateId { get; set; }

        /// <summary>
        /// 请求ID，由开发者生成并保证唯一性
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 卡包详情页面中展现出的卡码（可用于扫码核销）  qrcode: 二维码，扫码得商户开卡传入的external_card_no   barcode: 条形码，扫码得商户开卡传入的external_card_no
        /// </summary>
        [XmlElement("write_off_type")]
        public string WriteOffType { get; set; }
    }
}
