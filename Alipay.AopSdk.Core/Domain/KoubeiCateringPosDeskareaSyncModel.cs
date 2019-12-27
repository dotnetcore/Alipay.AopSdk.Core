using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// KoubeiCateringPosDeskareaSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosDeskareaSyncModel : AopObject
    {
        /// <summary>
        /// 餐区信息
        /// </summary>
        [XmlElement("desk_area")]
        public DeskAreaEntity DeskArea { get; set; }

        /// <summary>
        /// 标识接口所做操作，add 新增，update 修改，del 删除,其他返回 null
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
