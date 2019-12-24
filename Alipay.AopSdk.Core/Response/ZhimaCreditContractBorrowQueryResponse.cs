using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// ZhimaCreditContractBorrowQueryResponse.
    /// </summary>
    public class ZhimaCreditContractBorrowQueryResponse : AopResponse
    {
        /// <summary>
        /// 借还合约状态，INITED:初始化但未签约,SIGNED:已签约
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 借的物品列表，包括每个物品的唯一id，物品类型，物品名称。目前type仅支持book：图书
        /// </summary>
        [XmlElement("subjects_borrowed")]
        public string SubjectsBorrowed { get; set; }

        /// <summary>
        /// 归还的物品列表，包括每本书的唯一id，物品类型，物品名称
        /// </summary>
        [XmlElement("subjects_returned")]
        public string SubjectsReturned { get; set; }
    }
}
