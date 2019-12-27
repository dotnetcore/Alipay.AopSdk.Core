using Alipay.AopSdk.Core.Domain;
using Alipay.AopSdk.Core.Response;

namespace Alipay.AopSdk.F2FPay.Business
{
    /// <summary>
    /// AlipayF2FPayResult 的摘要说明
    /// </summary>
    public class AlipayF2FPayResult
    {
        public AlipayF2FPayResult()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

        public AlipayTradePayResponse response { get; set; }

        public ResultEnum Status
        {
            get
            {

                if (response != null)
                {
                    if (response.Code == ResultCode.SUCCESS)
                    {
                        return ResultEnum.SUCCESS;
                    }
                    else
                        return ResultEnum.FAILED;
                }
                else
                {
                    return ResultEnum.UNKNOWN;
                }
            }

        }


    }
}