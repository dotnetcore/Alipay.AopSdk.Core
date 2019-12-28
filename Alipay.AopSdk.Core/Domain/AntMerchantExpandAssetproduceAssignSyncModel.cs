using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AntMerchantExpandAssetproduceAssignSyncModel Data Structure.
	/// </summary>
	[Serializable]
	public class AntMerchantExpandAssetproduceAssignSyncModel : AopObject
	{
		/// <summary>
		///     生产指令接收情况，最多200条
		/// </summary>
		[JsonProperty("asset_results")]
		
		public List<AssetResult> AssetResults { get; set; }
	}
}