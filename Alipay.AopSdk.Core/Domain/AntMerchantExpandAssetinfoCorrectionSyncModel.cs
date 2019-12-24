using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntMerchantExpandAssetinfoCorrectionSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandAssetinfoCorrectionSyncModel : AopObject
    {
        /// <summary>
        /// 物料信息更正请求
        /// </summary>
        [XmlElement("asset_correction")]
        public AssetInfoCorrectionItem AssetCorrection { get; set; }
    }
}
