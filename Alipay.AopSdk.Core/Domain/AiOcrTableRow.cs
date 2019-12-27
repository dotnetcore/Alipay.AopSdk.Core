using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AiOcrTableRow Data Structure.
    /// </summary>
    [Serializable]
    public class AiOcrTableRow : AopObject
    {
        /// <summary>
        /// table一行的内容
        /// </summary>
        [XmlArray("row")]
        [XmlArrayItem("ai_ocr_table_context")]
        public List<AiOcrTableContext> Row { get; set; }
    }
}
