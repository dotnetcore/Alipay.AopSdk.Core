using System;
using System.Collections.Generic;
using System.Xml.Serialization;

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
		[XmlArray("return_qrcodes")]
		[XmlArrayItem("access_return_qrcode")]
		public List<AccessReturnQrcode> ReturnQrcodes { get; set; }
	}
}