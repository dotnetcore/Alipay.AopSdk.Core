using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayEcoMedicalcareSiDataSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMedicalcareSiDataSendModel : AopObject
    {
        /// <summary>
        /// 场景标识  si_payment_income 缴费到账  si_medical_consume_detail 医保消费  si_medical_consume_month 医保月账单
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 城市编码，国标码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [XmlElement("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 根据场景不同的模型数据, json 数组格式
        /// </summary>
        [XmlArray("si_data")]
        [XmlArrayItem("si_data")]
        public List<SiData> SiData { get; set; }

        /// <summary>
        /// 返佣合作伙伴id
        /// </summary>
        [XmlElement("sys_service_provider_id")]
        public string SysServiceProviderId { get; set; }

        /// <summary>
        /// 通知时间，为空为当前时间立即发送  格式：yyyyMMddHHmms
        /// </summary>
        [XmlElement("target_notify_time")]
        public string TargetNotifyTime { get; set; }
    }
}
