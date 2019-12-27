using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayDataBillBailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataBillBailQueryModel : AopObject
    {
        /// <summary>
        /// 保证金类型，目前支持TMALL_BAIL-天猫保证金，TAOBAO_BAIL-淘宝保证金
        /// </summary>
        [XmlElement("bail_type")]
        public string BailType { get; set; }

        /// <summary>
        /// 业务基础订单号。如果查询参数中指定订单号，则只查询相关的记录
        /// </summary>
        [XmlElement("biz_orig_no")]
        public string BizOrigNo { get; set; }

        /// <summary>
        /// 保证金流水创建时间的结束范围。与起始时间间隔不超过31天。查询结果为起始时间至结束时间的左闭右开区间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 保证金流水创建时间的起始范围
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 保证金流水号。如果查询参数中指定流水号，则只查询流水号相关的记录
        /// </summary>
        [XmlElement("trans_log_id")]
        public string TransLogId { get; set; }
    }
}
