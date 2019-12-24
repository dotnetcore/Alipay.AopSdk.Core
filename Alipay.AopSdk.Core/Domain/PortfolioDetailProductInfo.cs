using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// PortfolioDetailProductInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PortfolioDetailProductInfo : AopObject
    {
        /// <summary>
        /// 产品资产类型
        /// </summary>
        [XmlElement("asset_category")]
        public string AssetCategory { get; set; }

        /// <summary>
        /// 产品名称（简称）目前是基金简称
        /// </summary>
        [XmlElement("product_abbr_name")]
        public string ProductAbbrName { get; set; }

        /// <summary>
        /// 产品代码，目前是基金代码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 产品占比，四舍五入后保留小数点后4位
        /// </summary>
        [XmlElement("product_proportion")]
        public string ProductProportion { get; set; }

        /// <summary>
        /// 产品类型
        /// </summary>
        [XmlElement("product_type")]
        public string ProductType { get; set; }
    }
}
