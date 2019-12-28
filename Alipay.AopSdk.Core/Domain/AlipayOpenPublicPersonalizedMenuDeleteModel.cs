using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenPublicPersonalizedMenuDeleteModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenPublicPersonalizedMenuDeleteModel : AopObject
	{
		/// <summary>
		///     要删除的个性化菜单key
		/// </summary>
		[JsonProperty("menu_key")]
		public string MenuKey { get; set; }
	}
}