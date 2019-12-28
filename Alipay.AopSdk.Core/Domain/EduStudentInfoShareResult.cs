using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     EduStudentInfoShareResult Data Structure.
	/// </summary>
	[Serializable]
	public class EduStudentInfoShareResult : AopObject
	{
		/// <summary>
		///     教育分类
		/// </summary>
		[JsonProperty("biz_type")]
		public string BizType { get; set; }

		/// <summary>
		///     学生详细信息
		/// </summary>
		[JsonProperty("student_infos")]
		
		public List<StudentInfo> StudentInfos { get; set; }

		/// <summary>
		///     用户的userid
		/// </summary>
		[JsonProperty("user_id")]
		public string UserId { get; set; }
	}
}