using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ZhimaCreditContractBorrowInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditContractBorrowInitializeModel : AopObject
    {
        /// <summary>
        /// 用户加入合约成功后跳转的小程序地址
        /// </summary>
        [XmlElement("callback_url")]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 外部类目,样例：图书馆:book
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 扩展字段，目前留空
        /// </summary>
        [XmlElement("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 是否isv模式，0:非ISV模式,1:isv模式
        /// </summary>
        [XmlElement("isv_mode")]
        public string IsvMode { get; set; }

        /// <summary>
        /// 0:二维码扫描模式 1：扫码枪模式
        /// </summary>
        [XmlElement("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 加入合约成功后的异步通知页面，一般为http的地址，在收到通知后，商户做自身的业务逻辑处理
        /// </summary>
        [XmlArray("notify_addr")]
        [XmlArrayItem("string")]
        public List<string> NotifyAddr { get; set; }

        /// <summary>
        /// 商户自定义的外部订单号
        /// </summary>
        [XmlElement("out_trans_no")]
        public string OutTransNo { get; set; }

        /// <summary>
        /// 以28开头的二维码字符串，在mode=1(扫码枪模式)下必须传
        /// </summary>
        [XmlElement("qr_code")]
        public string QrCode { get; set; }

        /// <summary>
        /// 商户入驻芝麻服务后，得到的服务id，在服务入驻后台可看到
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }
    }
}
