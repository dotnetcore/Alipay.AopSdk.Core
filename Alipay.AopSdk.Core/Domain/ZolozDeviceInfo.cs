using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ZolozDeviceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ZolozDeviceInfo : AopObject
    {
        /// <summary>
        /// 客户端设备指纹
        /// </summary>
        [XmlElement("apdid")]
        public string Apdid { get; set; }

        /// <summary>
        /// 无线客户端名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 无线客户端版本
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// GSM基站号,是个16位的数据
        /// </summary>
        [XmlElement("cid")]
        public string Cid { get; set; }

        /// <summary>
        /// 屏幕长
        /// </summary>
        [XmlElement("h")]
        public string H { get; set; }

        /// <summary>
        /// 用户当前操作手机硬件标识
        /// </summary>
        [XmlElement("imei")]
        public string Imei { get; set; }

        /// <summary>
        /// 手机的SIM卡信息
        /// </summary>
        [XmlElement("imsi")]
        public string Imsi { get; set; }

        /// <summary>
        /// 客户端ip
        /// </summary>
        [XmlElement("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// GSM基站区域
        /// </summary>
        [XmlElement("lac")]
        public string Lac { get; set; }

        /// <summary>
        /// 出现地址的纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 出现地址的纬度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// MAC地址
        /// </summary>
        [XmlElement("mac")]
        public string Mac { get; set; }

        /// <summary>
        /// GSM基站国家代码,移动国家代码(中国的为460)
        /// </summary>
        [XmlElement("mcc")]
        public string Mcc { get; set; }

        /// <summary>
        /// GSM基站网络代码,移动网络号码(中国移动为00，中国联通为01，中国电信为02)
        /// </summary>
        [XmlElement("mnc")]
        public string Mnc { get; set; }

        /// <summary>
        /// 设备具体型号(IOS,ANDROID共享)
        /// </summary>
        [XmlElement("model")]
        public string Model { get; set; }

        /// <summary>
        /// 手机平台
        /// </summary>
        [XmlElement("os")]
        public string Os { get; set; }

        /// <summary>
        /// 分辨率
        /// </summary>
        [XmlElement("px")]
        public string Px { get; set; }

        /// <summary>
        /// Android设备QEMU虚拟化标识
        /// </summary>
        [XmlElement("qemu")]
        public string Qemu { get; set; }

        /// <summary>
        /// 设备系统版本
        /// </summary>
        [XmlElement("release")]
        public string Release { get; set; }

        /// <summary>
        /// 返回码
        /// </summary>
        [XmlElement("ret_code")]
        public string RetCode { get; set; }

        /// <summary>
        /// 是否越狱
        /// </summary>
        [XmlElement("root")]
        public string Root { get; set; }

        /// <summary>
        /// GSM基站信号强度
        /// </summary>
        [XmlElement("rssi")]
        public string Rssi { get; set; }

        /// <summary>
        /// 统一SDK版本
        /// </summary>
        [XmlElement("sdk_name")]
        public string SdkName { get; set; }

        /// <summary>
        /// 统一SDK版本
        /// </summary>
        [XmlElement("sdk_version")]
        public string SdkVersion { get; set; }

        /// <summary>
        /// sn
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// wifi的名称
        /// </summary>
        [XmlElement("ssid")]
        public string Ssid { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 快捷tid
        /// </summary>
        [XmlElement("tid")]
        public string Tid { get; set; }

        /// <summary>
        /// 淘宝无线安全设备标识
        /// </summary>
        [XmlElement("umid")]
        public string Umid { get; set; }

        /// <summary>
        /// 淘系客户端和友盟使用的设备标识
        /// </summary>
        [XmlElement("utdid")]
        public string Utdid { get; set; }

        /// <summary>
        /// 屏幕宽
        /// </summary>
        [XmlElement("w")]
        public string W { get; set; }

        /// <summary>
        /// wifi的mac地址
        /// </summary>
        [XmlElement("wireless_mac")]
        public string WirelessMac { get; set; }
    }
}
