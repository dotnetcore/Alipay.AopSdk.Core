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
			return JsonConvert.SerializeObject(res);
		}
	}
}