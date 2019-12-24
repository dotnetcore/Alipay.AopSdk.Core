using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KdsInfoModel Data Structure.
    /// </summary>
    [Serializable]
    public class KdsInfoModel : AopObject
    {
        /// <summary>
        /// 是否删除 false删除，true删除
        /// </summary>
        [XmlElement("delete_flag")]
        public bool DeleteFlag { get; set; }

        /// <summary>
        /// 设备列表
        /// </summary>
        [XmlArray("device_list")]
        [XmlArrayItem("kds_device_model")]
        public List<KdsDeviceModel> DeviceList { get; set; }

        /// <summary>
        /// 就餐模式可多选枚举如下：  TO_GO("TO_GO", "外带"),  TAKE_OUT("TAKE_OUT", "外卖"),  FOR_HERE("FOR_HERE", "堂食"),  全选回传ALL，ALL与其它类型不兼容
        /// </summary>
        [XmlArray("dinner_type")]
        [XmlArrayItem("string")]
        public List<string> DinnerType { get; set; }

        /// <summary>
        /// 是否有设备绑定，false无，true有
        /// </summary>
        [XmlElement("has_device")]
        public bool HasDevice { get; set; }

        /// <summary>
        /// 是否有档口，false没有，true有
        /// </summary>
        [XmlElement("has_stall")]
        public bool HasStall { get; set; }

        /// <summary>
        /// KDSID
        /// </summary>
        [XmlElement("kds_id")]
        public string KdsId { get; set; }

        /// <summary>
        /// KDS名称
        /// </summary>
        [XmlElement("kds_name")]
        public string KdsName { get; set; }

        /// <summary>
        /// kds屏幕类型：  ("COOK", "制作屏"),  ("PREPARE", "备餐屏"),  ("TAKE", "取餐屏"),
        /// </summary>
        [XmlElement("kds_type")]
        public string KdsType { get; set; }

        /// <summary>
        /// 是否打印，false不打印，true打印
        /// </summary>
        [XmlElement("print_flag")]
        public bool PrintFlag { get; set; }

        /// <summary>
        /// kds绑定的打印机设备ID  print_flag为true时，该字段必填
        /// </summary>
        [XmlElement("printer_device_id")]
        public string PrinterDeviceId { get; set; }

        /// <summary>
        /// 打印机列表
        /// </summary>
        [XmlArray("printer_list")]
        [XmlArrayItem("kds_printer_model")]
        public List<KdsPrinterModel> PrinterList { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
