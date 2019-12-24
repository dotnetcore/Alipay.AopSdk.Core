using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntMerchantExpandAssetreverseAssignQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandAssetreverseAssignQueryModel : AopObject
    {
        /// <summary>
        /// 每次拉取最大记录数量，可选值为[1,200] ;
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
