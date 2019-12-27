using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// UserSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class UserSubmitModel : AopObject
    {
        /// <summary>
        /// 提交答案中每道题的具体答案数据
        /// </summary>
        [XmlArray("answers")]
        [XmlArrayItem("answer_model")]
        public List<AnswerModel> Answers { get; set; }

        /// <summary>
        /// 用户答案提交时间
        /// </summary>
        [XmlElement("gmt_submit")]
        public string GmtSubmit { get; set; }

        /// <summary>
        /// 对应的任务id信息，根据入参的 job_id 或 snapshot_id 返回
        /// </summary>
        [XmlElement("job_id")]
        public long JobId { get; set; }

        /// <summary>
        /// 填写来源标记
        /// </summary>
        [XmlElement("referrer")]
        public string Referrer { get; set; }

        /// <summary>
        /// 试卷得分
        /// </summary>
        [XmlElement("score")]
        public long Score { get; set; }

        /// <summary>
        /// 答案对应的问卷快照版本_通过传入的 job_id 和 snapshot_id 获取
        /// </summary>
        [XmlElement("snapshot_id")]
        public long SnapshotId { get; set; }

        /// <summary>
        /// 用户提交问卷时的随机码信息
        /// </summary>
        [XmlElement("submit_id")]
        public string SubmitId { get; set; }

        /// <summary>
        /// 对应账号类型下的唯一账号主键_用以区分对应的填写用户  和入参参数一致，不需要脱敏
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 账号类型_用以区分不同账号体系的用户    ALIPAY-支付宝  HEMA-盒马  ALIBABA_INC-内部域账号
        /// </summary>
        [XmlElement("user_type")]
        public string UserType { get; set; }
    }
}
