using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEcoEduKtBillingSendModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEcoEduKtBillingSendModel : AopObject
	{
        /// <summary>
        ///     总金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]，  如果是非多选项，是要和缴费项的总和相同，多选模式不做验证
        /// </summary>
        [JsonProperty("amount")]
		public string Amount { get; set; }

		/// <summary>
		///     缴费账单名称
		/// </summary>
		[JsonProperty("charge_bill_title")]
		public string ChargeBillTitle { get; set; }

		/// <summary>
		///     缴费详情：输入json格式字符串。Json定义：key填写缴费项名称，value填写缴费项金额，金额保留2位小数
		/// </summary>
		[JsonProperty("charge_item")]
		
		public List<ChargeItems> ChargeItem { get; set; }

        /// <summary>
        ///     缴费项模式：空或"N"，表示缴费项不可选，  "M"表示缴费项为可选 ，支持单选和多选。
        /// </summary>
        [JsonProperty("charge_type")]
        public string ChargeType { get; set; }

        /// <summary>
        ///     孩子名字
        /// </summary>
        [JsonProperty("child_name")]
		public string ChildName { get; set; }

		/// <summary>
		///     孩子所在班级
		/// </summary>
		[JsonProperty("class_in")]
		public string ClassIn { get; set; }

		/// <summary>
		///     截止日期是否生效，与gmt_end_time发布配合使用,N为gmt_end_time不生效，用户过期后仍可以缴费；Y为gmt_end_time生效，用户过期后，不能再缴费。
		/// </summary>
		[JsonProperty("end_enable")]
		public string EndEnable { get; set; }

		/// <summary>
		///     缴费截止时间，格式"yyyy-MM-dd HH:mm:ss"
		/// </summary>
		[JsonProperty("gmt_end")]
		public string GmtEnd { get; set; }

		/// <summary>
		///     孩子所在年级
		/// </summary>
		[JsonProperty("grade")]
		public string Grade { get; set; }

		/// <summary>
		///     ISV端的缴费账单编号
		/// </summary>
		[JsonProperty("out_trade_no")]
		public string OutTradeNo { get; set; }

		/// <summary>
		///     ISV_NO, 支付宝签约后，返回给ISV编号
		/// </summary>
		[JsonProperty("partner_id")]
		public string PartnerId { get; set; }

		/// <summary>
		///     学校编码，录入学校接口返回的参数
		/// </summary>
		[JsonProperty("school_no")]
		public string SchoolNo { get; set; }

		/// <summary>
		///     学校支付宝pid
		/// </summary>
		[JsonProperty("school_pid")]
		public string SchoolPid { get; set; }

        /// <summary>
        ///     学生的学号，只支持字母和数字类型，一般以教育局学号为准，作为学生的唯一标识。此字段与student_identify、家长user_mobile至少选一个
        /// </summary>
        [JsonProperty("student_code")]
		public string StudentCode { get; set; }

        /// <summary>
        ///     学生的身份证号，如果ISV有学生身份证号，则同步身份证号作为学生唯一标识。此字段与student_code、家长user_mobile至少选一个。  大陆身份证必须是18位 ， 其它地区或国家的身份证开头需要加"IC"开头区分并且不超过18位，但查询账单的时候不要带"IC"
        /// </summary>
        [JsonProperty("student_identify")]
		public string StudentIdentify { get; set; }

        /// <summary>
        ///     孩子的家长信息，最多一次输入10个家长，此字段做为识别家长的孩子用，与student_identify、student_code至少选一个
        /// </summary>
        [JsonProperty("users")]
		
		public List<UserDetails> Users { get; set; }
	}
}