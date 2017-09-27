using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayCommerceEducateStudentinfoShareResponse.
	/// </summary>
	public class AlipayCommerceEducateStudentinfoShareResponse : AopResponse
	{
		/// <summary>
		///     学生信息
		/// </summary>
		[JsonProperty("student_info_share_result")]
		public EduStudentInfoShareResult StudentInfoShareResult { get; set; }
	}
}