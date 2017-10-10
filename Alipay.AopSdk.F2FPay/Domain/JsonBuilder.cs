using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.F2FPay.Domain
{

    /// <summary>
    /// Class1 的摘要说明
    /// </summary>
    public abstract class JsonBuilder
    {

        // 验证bizContent对象
         public abstract bool Validate();

        // 将bizContent对象转换为json字符串
        public string BuildJson()
        {
	        return JsonConvert.SerializeObject(this);
        }
    }
}