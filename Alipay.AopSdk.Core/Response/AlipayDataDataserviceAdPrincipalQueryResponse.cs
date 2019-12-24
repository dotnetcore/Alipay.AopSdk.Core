using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdPrincipalQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdPrincipalQueryResponse : AopResponse
    {
        /// <summary>
        /// 商家支付宝PID
        /// </summary>
        [XmlElement("alipay_pid")]
        public string AlipayPid { get; set; }

        /// <summary>
        /// 商家的全量资质列表
        /// </summary>
        [XmlArray("attachment_list")]
        [XmlArrayItem("outer_attachment")]
        public List<OuterAttachment> AttachmentList { get; set; }

        /// <summary>
        /// 商家id
        /// </summary>
        [XmlElement("principal_id")]
        public long PrincipalId { get; set; }

        /// <summary>
        /// 状态：  ENABLE-生效  DISABLE-失效  CHECKING-待审核  FAILEDCHECK-审核未通过  INIT-初始化  RE_SIGN-待重签
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 二级行业ID
        /// </summary>
        [XmlElement("trade_id")]
        public string TradeId { get; set; }
    }
}
