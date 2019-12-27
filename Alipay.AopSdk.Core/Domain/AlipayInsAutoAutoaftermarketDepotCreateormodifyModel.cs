using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayInsAutoAutoaftermarketDepotCreateormodifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsAutoAutoaftermarketDepotCreateormodifyModel : AopObject
    {
        /// <summary>
        /// 操作类型:  ONLINE-上线，  OFFLINE-下线，  UPDATE-修改修理厂信息（如修改修理厂名称，修理厂某几天的库存）
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 营业结束时间，格式:HH:MM
        /// </summary>
        [XmlElement("business_end_time")]
        public string BusinessEndTime { get; set; }

        /// <summary>
        /// 开始营业时间，格式HH:MM
        /// </summary>
        [XmlElement("business_start_time")]
        public string BusinessStartTime { get; set; }

        /// <summary>
        /// 需要更新库存的日期:  如果需要修改某几天的库存，该字段必传，若该字段不传，则默认修改所有的库存  格式:yyyy-MM-dd
        /// </summary>
        [XmlArray("calendars")]
        [XmlArrayItem("string")]
        public List<string> Calendars { get; set; }

        /// <summary>
        /// 修理厂支付宝账号，用于后续结算线上化
        /// </summary>
        [XmlElement("depot_account")]
        public string DepotAccount { get; set; }

        /// <summary>
        /// 修理厂详细地址
        /// </summary>
        [XmlElement("depot_address")]
        public string DepotAddress { get; set; }

        /// <summary>
        /// 服务商侧的修理厂id，需要唯一
        /// </summary>
        [XmlElement("depot_id")]
        public string DepotId { get; set; }

        /// <summary>
        /// 修理厂名称
        /// </summary>
        [XmlElement("depot_name")]
        public string DepotName { get; set; }

        /// <summary>
        /// 扩展信息，json格式
        /// </summary>
        [XmlElement("extra")]
        public string Extra { get; set; }

        /// <summary>
        /// 修理厂联系方式
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 修理厂维修范围，json格式
        /// </summary>
        [XmlElement("repair_scope")]
        public string RepairScope { get; set; }

        /// <summary>
        /// 修理厂每日可修数量
        /// </summary>
        [XmlElement("threshold")]
        public long Threshold { get; set; }
    }
}
