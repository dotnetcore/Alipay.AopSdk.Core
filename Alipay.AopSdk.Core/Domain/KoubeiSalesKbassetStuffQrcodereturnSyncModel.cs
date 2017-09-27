using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiSalesKbassetStuffQrcodereturnSyncModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiSalesKbassetStuffQrcodereturnSyncModel : AopObject
	{
		/// <summary>
		///     供应商回传码物料码值记录（最多200条）
		/// </summary>
		[JsonProperty("return_qrcodes")]
		
		public List<AccessReturnQrcode> ReturnQrcodes { get; set; }
	}
}