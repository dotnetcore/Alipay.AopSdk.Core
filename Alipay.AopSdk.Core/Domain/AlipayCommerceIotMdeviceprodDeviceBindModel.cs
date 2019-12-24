using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodDeviceBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotMdeviceprodDeviceBindModel : AopObject
    {
        /// <summary>
        /// 设备唯一标识，设备id;identity_type='ID'时必填
        /// </summary>
        [XmlElement("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 设备SN，与supplier_id配合作为设备识别的唯一标识;identity_type='SN'时必填
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 绑定扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 可选项[SN,ID]  SN-使用device_sn、supplier_id联合作为设备唯一识别标识  ID-使用biz_tid作为设备唯一识别标识
        /// </summary>
        [XmlElement("identify_type")]
        public string IdentifyType { get; set; }

        /// <summary>
        /// 绑定关系
        /// </summary>
        [XmlArray("principal")]
        [XmlArrayItem("iot_device_principal")]
        public List<IotDevicePrincipal> Principal { get; set; }

        /// <summary>
        /// 设备供应商id，与device_sn配合作为设备识别唯一标识;identity_type='SN'时必填
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }
    }
}
