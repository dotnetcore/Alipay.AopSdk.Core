using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// PoiQueryResult Data Structure.
    /// </summary>
    [Serializable]
    public class PoiQueryResult : AopObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 英文地址
        /// </summary>
        [XmlElement("address_en")]
        public string AddressEn { get; set; }

        /// <summary>
        /// 当地地址
        /// </summary>
        [XmlElement("address_local")]
        public string AddressLocal { get; set; }

        /// <summary>
        /// 备用号码
        /// </summary>
        [XmlElement("alternative_phone")]
        public string AlternativePhone { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        [XmlElement("bios")]
        public string Bios { get; set; }

        /// <summary>
        /// 品牌信息
        /// </summary>
        [XmlElement("brand_info")]
        public StructureBrandInfo BrandInfo { get; set; }

        /// <summary>
        /// 服务时间
        /// </summary>
        [XmlElement("business_hour")]
        public string BusinessHour { get; set; }

        /// <summary>
        /// 类目
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 商圈
        /// </summary>
        [XmlElement("commercial_circle")]
        public string CommercialCircle { get; set; }

        /// <summary>
        /// 人均消费
        /// </summary>
        [XmlElement("consumption")]
        public string Consumption { get; set; }

        /// <summary>
        /// 国家码
        /// </summary>
        [XmlElement("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// 国家
        /// </summary>
        [XmlElement("country_name")]
        public string CountryName { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("extend_map")]
        public string ExtendMap { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("lat")]
        public string Lat { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("lng")]
        public string Lng { get; set; }

        /// <summary>
        /// 当地语言
        /// </summary>
        [XmlElement("local_language")]
        public string LocalLanguage { get; set; }

        /// <summary>
        /// 本地名
        /// </summary>
        [XmlElement("local_name")]
        public string LocalName { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [XmlElement("main_phone")]
        public string MainPhone { get; set; }

        /// <summary>
        /// 地名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 别名
        /// </summary>
        [XmlElement("name_alias")]
        public string NameAlias { get; set; }

        /// <summary>
        /// 英文名
        /// </summary>
        [XmlElement("name_en")]
        public string NameEn { get; set; }

        /// <summary>
        /// 下线详细原因
        /// </summary>
        [XmlElement("offline_reason_detail")]
        public string OfflineReasonDetail { get; set; }

        /// <summary>
        /// poi状态
        /// </summary>
        [XmlElement("open_status")]
        public long OpenStatus { get; set; }

        /// <summary>
        /// 开放时间
        /// </summary>
        [XmlElement("open_time")]
        public string OpenTime { get; set; }

        /// <summary>
        /// 操作类型(0:新增 1:更新)
        /// </summary>
        [XmlElement("operator_type")]
        public long OperatorType { get; set; }

        /// <summary>
        /// 图片地址(,分隔多张)
        /// </summary>
        [XmlArray("photo_urls")]
        [XmlArrayItem("string")]
        public List<string> PhotoUrls { get; set; }

        /// <summary>
        /// poiId(飞猪端poiId)
        /// </summary>
        [XmlElement("poi_id")]
        public long PoiId { get; set; }

        /// <summary>
        /// 邮编
        /// </summary>
        [XmlElement("postal_code")]
        public string PostalCode { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 推荐信息
        /// </summary>
        [XmlElement("recommend_infos")]
        public string RecommendInfos { get; set; }

        /// <summary>
        /// 认领主账号id
        /// </summary>
        [XmlElement("seller_id")]
        public long SellerId { get; set; }

        /// <summary>
        /// 服务详情
        /// </summary>
        [XmlElement("service_info")]
        public StructureServiceInfo ServiceInfo { get; set; }

        /// <summary>
        /// 支付宝店铺id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺类型
        /// </summary>
        [XmlElement("shop_type")]
        public string ShopType { get; set; }

        /// <summary>
        /// 外部源唯一id
        /// </summary>
        [XmlElement("source_biz_id")]
        public string SourceBizId { get; set; }

        /// <summary>
        /// 中台门店id
        /// </summary>
        [XmlElement("store_id")]
        public long StoreId { get; set; }

        /// <summary>
        /// 子账号id
        /// </summary>
        [XmlElement("sub_seller_id")]
        public long SubSellerId { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("telephone")]
        public string Telephone { get; set; }

        /// <summary>
        /// 交通
        /// </summary>
        [XmlElement("transport")]
        public string Transport { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [XmlElement("type")]
        public long Type { get; set; }

        /// <summary>
        /// 视频url
        /// </summary>
        [XmlElement("video_url")]
        public string VideoUrl { get; set; }

        /// <summary>
        /// 外部url
        /// </summary>
        [XmlElement("web_site_url")]
        public string WebSiteUrl { get; set; }
    }
}
