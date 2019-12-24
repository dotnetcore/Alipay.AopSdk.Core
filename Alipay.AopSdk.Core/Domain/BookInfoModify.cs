using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// BookInfoModify Data Structure.
    /// </summary>
    [Serializable]
    public class BookInfoModify : AopObject
    {
        /// <summary>
        /// 订座桌台位置。如LOBBY表示大厅；如BOX表示包厢。
        /// </summary>
        [XmlElement("book_table_position")]
        public string BookTablePosition { get; set; }

        /// <summary>
        /// 订座确认超时时间。标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("book_timeout")]
        public string BookTimeout { get; set; }
    }
}
