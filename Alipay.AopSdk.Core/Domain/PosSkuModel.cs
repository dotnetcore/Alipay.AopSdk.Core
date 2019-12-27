using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// PosSkuModel Data Structure.
    /// </summary>
    [Serializable]
    public class PosSkuModel : AopObject
    {
        /// <summary>
        /// 餐盒费，除了删除，其他情况必传
        /// </summary>
        [XmlElement("box_price")]
        public string BoxPrice { get; set; }

        /// <summary>
        /// sku的销售价格，除了删除，其他情况必传
        /// </summary>
        [XmlElement("sell_price")]
        public string SellPrice { get; set; }

        /// <summary>
        /// sku的ID，更新和删除的时候必传  更新时如果新增了sku，不用传
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// sku的排序字段，除了删除，其他情况必传
        /// </summary>
        [XmlElement("sku_sort")]
        public long SkuSort { get; set; }

        /// <summary>
        /// 菜品规格的ID，如果是默认规格，可以不填，其余情况除了删除都需要填
        /// </summary>
        [XmlElement("spec_code_01")]
        public string SpecCode01 { get; set; }

        /// <summary>
        /// 规格的名字
        /// </summary>
        [XmlElement("spec_name_01")]
        public string SpecName01 { get; set; }

        /// <summary>
        /// sku的状态，除了删除，其他情况必传  open 启动 stop 停用
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
