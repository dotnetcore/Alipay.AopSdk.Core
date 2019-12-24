using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayUserAntarchiveCustrelationCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAntarchiveCustrelationCloseModel : AopObject
    {
        /// <summary>
        /// 关闭时间,可空.标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("close_date")]
        public string CloseDate { get; set; }

        /// <summary>
        /// 待关闭蚂蚁档案关联的客户id
        /// </summary>
        [XmlElement("cust_id")]
        public string CustId { get; set; }
    }
}
