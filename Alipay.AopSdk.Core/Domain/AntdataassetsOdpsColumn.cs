using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntdataassetsOdpsColumn Data Structure.
    /// </summary>
    [Serializable]
    public class AntdataassetsOdpsColumn : AopObject
    {
        /// <summary>
        /// 表的字段名称
        /// </summary>
        [XmlElement("column_name")]
        public string ColumnName { get; set; }

        /// <summary>
        /// 表的字段类型
        /// </summary>
        [XmlElement("column_type")]
        public string ColumnType { get; set; }
    }
}
