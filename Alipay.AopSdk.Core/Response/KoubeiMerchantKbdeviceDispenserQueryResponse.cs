using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// KoubeiMerchantKbdeviceDispenserQueryResponse.
    /// </summary>
    public class KoubeiMerchantKbdeviceDispenserQueryResponse : AopResponse
    {
        /// <summary>
        /// 取餐柜设备是否可用
        /// </summary>
        [XmlElement("availability")]
        public bool Availability { get; set; }

        /// <summary>
        /// 取餐柜的单元格详情列表
        /// </summary>
        [XmlArray("cell_info_list")]
        [XmlArrayItem("food_dispenser_cell_info")]
        public List<FoodDispenserCellInfo> CellInfoList { get; set; }

        /// <summary>
        /// 取餐柜的唯一设备ID
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }
    }
}
