using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAntdataassetsUploadjobCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAntdataassetsUploadjobCreateModel : AopObject
    {
        /// <summary>
        /// ODPS表的guid
        /// </summary>
        [XmlElement("guid")]
        public string Guid { get; set; }

        /// <summary>
        /// ODPS表的字段元信息，包括字段名和字段类型
        /// </summary>
        [XmlArray("odps_columns")]
        [XmlArrayItem("antdataassets_odps_column")]
        public List<AntdataassetsOdpsColumn> OdpsColumns { get; set; }
    }
}
