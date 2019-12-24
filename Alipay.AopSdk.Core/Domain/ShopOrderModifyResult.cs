using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ShopOrderModifyResult Data Structure.
    /// </summary>
    [Serializable]
    public class ShopOrderModifyResult : AopObject
    {
        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_infos")]
        public string ExtInfos { get; set; }

        /// <summary>
        /// SUCCESS: 设置成功  INVALID_PARAMETER: 参数错误  SHOP_NOT_EXIST:店铺不存在  NO_PRIVILEGE:没有权限修改此门店  NO_ORDER_INFO:没有开通过点餐  MODIFY_FAILED:修改失败
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 口碑门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 外部门店编号；最长32位字符，该编号将作为收单接口的入参， 请开发者自行确保其唯一性。
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
