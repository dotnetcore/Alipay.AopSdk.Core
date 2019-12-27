using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayAssetPointPointprodPointlibQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAssetPointPointprodPointlibQueryModel : AopObject
    {
        /// <summary>
        /// 集分宝积分库ID
        /// </summary>
        [XmlElement("point_lib_id")]
        public string PointLibId { get; set; }
    }
}
