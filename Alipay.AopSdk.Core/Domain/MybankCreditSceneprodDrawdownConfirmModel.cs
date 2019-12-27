using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MybankCreditSceneprodDrawdownConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSceneprodDrawdownConfirmModel : AopObject
    {
        /// <summary>
        /// 网商针对一次客户主动申请生成的申请单据编号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 证件主体名称
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 支用详情列表
        /// </summary>
        [XmlArray("drawdown_list")]
        [XmlArrayItem("scene_drawdown_detail")]
        public List<SceneDrawdownDetail> DrawdownList { get; set; }

        /// <summary>
        /// 错误原因 ，成功可以不填
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 资方生成的申请单号
        /// </summary>
        [XmlElement("fin_order_no")]
        public string FinOrderNo { get; set; }

        /// <summary>
        /// 放款结果，成功：Y，失败：N
        /// </summary>
        [XmlElement("process_result")]
        public string ProcessResult { get; set; }

        /// <summary>
        /// 放款通知备注信息
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 标识一次业务交互, 网商的ipRoleId+"_"YYYYMMDD+35位流水号, 最后2，3位要求是数字。
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
