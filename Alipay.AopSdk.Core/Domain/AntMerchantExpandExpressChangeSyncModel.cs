using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntMerchantExpandExpressChangeSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandExpressChangeSyncModel : AopObject
    {
        /// <summary>
        /// 传入需要上传的附件内容及相关业务参数
        /// </summary>
        [XmlElement("asset_logistics_record")]
        public AssetLogisticsRecord AssetLogisticsRecord { get; set; }
    }
}
