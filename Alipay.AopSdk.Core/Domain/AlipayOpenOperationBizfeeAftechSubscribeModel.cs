using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenOperationBizfeeAftechSubscribeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationBizfeeAftechSubscribeModel : AopObject
    {
        /// <summary>
        /// 系统/应用名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 合约编号
        /// </summary>
        [XmlElement("ar_no")]
        public string ArNo { get; set; }

        /// <summary>
        /// 客户信息（JSON对象） 包含principalType主体类型、principalId主体Id、extInfo扩展信息等字段。其中，需要从extInfo透传消费的key有：relEntityId关联主体Id。
        /// </summary>
        [XmlElement("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// 订购费用金额 单位元，最多两位小数。
        /// </summary>
        [XmlElement("fee_amount")]
        public string FeeAmount { get; set; }

        /// <summary>
        /// 订购费用币种 币种数字编码。
        /// </summary>
        [XmlElement("fee_currency")]
        public string FeeCurrency { get; set; }

        /// <summary>
        /// 订购开始时间
        /// </summary>
        [XmlElement("gmt_begin")]
        public string GmtBegin { get; set; }

        /// <summary>
        /// 订购结束时间
        /// </summary>
        [XmlElement("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 业务发生时间
        /// </summary>
        [XmlElement("gmt_service")]
        public string GmtService { get; set; }

        /// <summary>
        /// 机构OU编码
        /// </summary>
        [XmlElement("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 外部业务流水号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 订购包量类型 SERVICE_TIME: 包时间 SERVICE_QUANTITY: 包量
        /// </summary>
        [XmlElement("pkg_type")]
        public string PkgType { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 扩展属性（Map的JSON对象） key和value中不能有英文逗号及等于符号。
        /// </summary>
        [XmlElement("properties")]
        public string Properties { get; set; }

        /// <summary>
        /// 关联订单流水号
        /// </summary>
        [XmlElement("rel_order_no")]
        public string RelOrderNo { get; set; }

        /// <summary>
        /// 订购服务量 传天数/次数等数值。
        /// </summary>
        [XmlElement("service_amount")]
        public string ServiceAmount { get; set; }

        /// <summary>
        /// 租户Id
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
