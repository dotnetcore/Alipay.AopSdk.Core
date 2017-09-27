using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Parser
{
	public class AopModelParser
	{
		/// <summary>
		///     Json序列化AopObject对象
		/// </summary>
		/// <param name="res"></param>
		/// <returns></returns>
		public string SerializeAopObject(AopObject res)
		{
			JsonSerializerSettings jsetting = new JsonSerializerSettings();
			jsetting.NullValueHandling = NullValueHandling.Ignore;
			return JsonConvert.SerializeObject(res,Formatting.None,jsetting);
		}
	}
}