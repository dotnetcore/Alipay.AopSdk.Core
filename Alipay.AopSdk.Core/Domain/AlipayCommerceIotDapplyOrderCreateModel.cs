using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayCommerceIotDapplyOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotDapplyOrderCreateModel : AopObject
    {
        /// <summary>
        /// 申请人联系电话
        /// </summary>
        [XmlElement("applicant_mobile")]
        public string ApplicantMobile { get; set; }

        /// <summary>
        /// 申请人名称
        /// </summary>
        [XmlElement("applicant_name")]
        public string ApplicantName { get; set; }

        /// <summary>
        /// 申请人pid
        /// </summary>
        [XmlElement("applicant_pid")]
        public string ApplicantPid { get; set; }

        /// <summary>
        /// 申请人类型
        /// </summary>
        [XmlElement("applicant_type")]
        public string ApplicantType { get; set; }

        /// <summary>
        /// 申请总数量，order_item_list每个元素apply_amount之和
        /// </summary>
        [XmlElement("apply_amount")]
        public string ApplyAmount { get; set; }

        /// <summary>
        /// 物料申请模式
        /// </summary>
        [XmlElement("asset_apply_type")]
        public string AssetApplyType { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [XmlElement("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 订单创建子单集合
        /// </summary>
        [XmlArray("device_apply_order_item_models")]
        [XmlArrayItem("device_apply_order_item_dto")]
        public List<DeviceApplyOrderItemDto> DeviceApplyOrderItemModels { get; set; }

        /// <summary>
        /// 扩展字段，JSON字符串
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 行业场景
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 行业场景名称
        /// </summary>
        [XmlElement("scene_name")]
        public string SceneName { get; set; }

        /// <summary>
        /// 店铺Id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 来源渠道, 供应商系统为：DSUPPLIER
        /// </summary>
        [XmlElement("source_code")]
        public string SourceCode { get; set; }
    }
}
