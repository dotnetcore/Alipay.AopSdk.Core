using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOpenPublicMenuQueryResponse.
	/// </summary>
	public class AlipayOpenPublicMenuQueryResponse : AopResponse
	{
		/// <summary>
		///     一级菜单数组，个数应为1~4个
		/// </summary>
		[XmlElement("menu_content")]
		public string MenuContent { get; set; }
	}
}