using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiRetailWmsWarehouseModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsWarehouseModifyModel : AopObject
    {
        /// <summary>
        /// 扩展信息  ADMIN_PHONE:管理员电话  CITY_MANAGER_PHONE:城市经理电话  PURCHASE_MANAGER_PHONE:采购经理电话
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 是否开启安全库存开关 ON打开 OFF关闭
        /// </summary>
        [XmlElement("safety_inventory_switch")]
        public string SafetyInventorySwitch { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [XmlElement("warehouse_code")]
        public string WarehouseCode { get; set; }
    }
}
