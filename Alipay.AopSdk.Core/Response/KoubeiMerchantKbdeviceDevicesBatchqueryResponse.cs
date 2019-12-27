using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// KoubeiMerchantKbdeviceDevicesBatchqueryResponse.
    /// </summary>
    public class KoubeiMerchantKbdeviceDevicesBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 门店下设备列表
        /// </summary>
        [XmlArray("device_info_list")]
        [XmlArrayItem("device_info")]
        public List<DeviceInfo> DeviceInfoList { get; set; }
    }
}
