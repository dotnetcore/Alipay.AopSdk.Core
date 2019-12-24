using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// EbppUserChargeInstInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EbppUserChargeInstInfo : AopObject
    {
        /// <summary>
        /// 业务类型缩写:  JF-缴费
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 出账机构缩写
        /// </summary>
        [XmlElement("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 出账机构全称
        /// </summary>
        [XmlElement("charge_inst_name")]
        public string ChargeInstName { get; set; }

        /// <summary>
        /// 子业务类型英文名称:  ELECTRIC-电力  GAS-燃气  WATER-水
        /// </summary>
        [XmlElement("sub_biz_type")]
        public string SubBizType { get; set; }
    }
}
