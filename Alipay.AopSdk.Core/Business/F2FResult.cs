using Alipay.AopSdk.Core;

namespace Alipay.AopSdk.F2FPay.Business
{

    /// <summary>
    /// F2FResult 的摘要说明
    /// </summary>
    public abstract class F2FResult
    {
        public abstract bool IsSuccess();
        public abstract AopResponse AopResponse();

    }
}