using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// OcrIdentifyResult Data Structure.
    /// </summary>
    [Serializable]
    public class OcrIdentifyResult : AopObject
    {
        /// <summary>
        /// 当识别驾驶证时，返回家庭住址；
        /// </summary>
        [XmlElement("addr")]
        public string Addr { get; set; }

        /// <summary>
        /// 当识别营业执照时，返回注册地址；  当识别身份证时，返回家庭住址；
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 当识别身份证时，返回生日
        /// </summary>
        [XmlElement("birth")]
        public string Birth { get; set; }

        /// <summary>
        /// 当识别营业执照时，返回经营范围
        /// </summary>
        [XmlElement("business")]
        public string Business { get; set; }

        /// <summary>
        /// 当识别营业执照时，返回注册资本
        /// </summary>
        [XmlElement("captial")]
        public string Captial { get; set; }

        /// <summary>
        /// 当识别银行卡时，返回银行卡号
        /// </summary>
        [XmlElement("card_num")]
        public string CardNum { get; set; }

        /// <summary>
        /// 调用结果编码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 当识别驾驶证时，返回证件有效期结束时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 当识别行驶证时，返回发动机号
        /// </summary>
        [XmlElement("engine_num")]
        public string EngineNum { get; set; }

        /// <summary>
        /// 当识别营业执照时，返回注册时间
        /// </summary>
        [XmlElement("establish_date")]
        public string EstablishDate { get; set; }

        /// <summary>
        /// 当识别行驶证时，返回发证日期
        /// </summary>
        [XmlElement("issue_date")]
        public string IssueDate { get; set; }

        /// <summary>
        /// 调用结果说明
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 当识别营业执照时，返回公司名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 当识别身份证时，返回民族
        /// </summary>
        [XmlElement("nationality")]
        public string Nationality { get; set; }

        /// <summary>
        /// 当识别驾驶证时，返回证件号码；  当识别身份证时，返回身份证号码；
        /// </summary>
        [XmlElement("num")]
        public string Num { get; set; }

        /// <summary>
        /// 当识别行驶证时，返回所有人
        /// </summary>
        [XmlElement("owner")]
        public string Owner { get; set; }

        /// <summary>
        /// 当识别营业执照时，返回公司法人
        /// </summary>
        [XmlElement("person")]
        public string Person { get; set; }

        /// <summary>
        /// 当识别行驶证时，返回车牌
        /// </summary>
        [XmlElement("plate_num")]
        public string PlateNum { get; set; }

        /// <summary>
        /// 当识别营业执照时，返回注册编号
        /// </summary>
        [XmlElement("reg_num")]
        public string RegNum { get; set; }

        /// <summary>
        /// 当识别行驶证时，返回注册时间
        /// </summary>
        [XmlElement("register_date")]
        public string RegisterDate { get; set; }

        /// <summary>
        /// request_id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 当识别身份证时，返回性别
        /// </summary>
        [XmlElement("sex")]
        public string Sex { get; set; }

        /// <summary>
        /// 当识别驾驶证时，返回证件有效期起始时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 识别是否成功
        /// </summary>
        [XmlElement("success")]
        public string Success { get; set; }

        /// <summary>
        /// trace_id
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 当识别行驶证时，返回使用性质
        /// </summary>
        [XmlElement("use_character")]
        public string UseCharacter { get; set; }

        /// <summary>
        /// 当识别营业执照时，返回有效期
        /// </summary>
        [XmlElement("valid_period")]
        public string ValidPeriod { get; set; }

        /// <summary>
        /// 当识别驾驶证时，返回证件准驾车型；  当识别行驶证时，返回车辆类型；
        /// </summary>
        [XmlElement("vehicle_type")]
        public string VehicleType { get; set; }

        /// <summary>
        /// 当识别车架号时，返回车架号；  当识别行驶证时，返回车辆识别代号；
        /// </summary>
        [XmlElement("vin")]
        public string Vin { get; set; }
    }
}
