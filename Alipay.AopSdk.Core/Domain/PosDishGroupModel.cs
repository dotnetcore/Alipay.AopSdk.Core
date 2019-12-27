using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// PosDishGroupModel Data Structure.
    /// </summary>
    [Serializable]
    public class PosDishGroupModel : AopObject
    {
        /// <summary>
        /// 创建的用户名，请输入有效的用户ID，类型是新增时候，必填
        /// </summary>
        [XmlElement("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 组合菜的详情，类型是删除时候可选，否则必填
        /// </summary>
        [XmlArray("detail_list")]
        [XmlArrayItem("pos_dish_group_detail_model")]
        public List<PosDishGroupDetailModel> DetailList { get; set; }

        /// <summary>
        /// 组合菜的ID，除了新增时候，必传
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 组合菜的名称, 类型是删除时候可选，否则必填
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 查询时候返回的详情列表
        /// </summary>
        [XmlArray("query_detail_list")]
        [XmlArrayItem("pos_dish_group_detail_model")]
        public List<PosDishGroupDetailModel> QueryDetailList { get; set; }

        /// <summary>
        /// 门店ID，类型是删除时候可选，否则必填
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 套餐的排序号，只在查询套餐下组合菜的时候才会有这个值
        /// </summary>
        [XmlElement("sort")]
        public long Sort { get; set; }

        /// <summary>
        /// 状态，类型是删除时候可选，否则必填
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 操作的类型，add新增 update更新 del删除
        /// </summary>
        [XmlElement("sync_type")]
        public string SyncType { get; set; }

        /// <summary>
        /// 组合菜中最多可点份数，类型是删除时候可选，否则必填
        /// </summary>
        [XmlElement("unit_count_limit")]
        public long UnitCountLimit { get; set; }

        /// <summary>
        /// 更新的用户名，请输入有效的用户ID，类型是新增时候可选，否则必填
        /// </summary>
        [XmlElement("update_user")]
        public string UpdateUser { get; set; }
    }
}
