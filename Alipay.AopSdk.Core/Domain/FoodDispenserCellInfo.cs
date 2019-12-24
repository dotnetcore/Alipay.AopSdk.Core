using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// FoodDispenserCellInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FoodDispenserCellInfo : AopObject
    {
        /// <summary>
        /// 业务状态  空闲：IDLE  预占：FREEZE  占用：OCCUPIED
        /// </summary>
        [XmlElement("biz_status")]
        public string BizStatus { get; set; }

        /// <summary>
        /// 单元格编号
        /// </summary>
        [XmlElement("cell_code")]
        public string CellCode { get; set; }

        /// <summary>
        /// 单元格名称
        /// </summary>
        [XmlElement("cell_name")]
        public string CellName { get; set; }

        /// <summary>
        /// 列数
        /// </summary>
        [XmlElement("column_no")]
        public string ColumnNo { get; set; }

        /// <summary>
        /// 行数
        /// </summary>
        [XmlElement("row_no")]
        public string RowNo { get; set; }
    }
}
