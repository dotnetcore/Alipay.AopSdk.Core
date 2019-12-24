using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayCommerceIotSupplierAssetBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotSupplierAssetBatchqueryModel : AopObject
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("cur_page_num")]
        public long CurPageNum { get; set; }

        /// <summary>
        /// 搜索关键字，设备型号、设备名称等
        /// </summary>
        [XmlElement("keyword")]
        public string Keyword { get; set; }

        /// <summary>
        /// 查询分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 供应商pid
        /// </summary>
        [XmlElement("supplier_pid")]
        public string SupplierPid { get; set; }
    }
}
