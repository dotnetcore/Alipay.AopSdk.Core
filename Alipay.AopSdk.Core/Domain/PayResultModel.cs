//using System.Linq;

namespace Alipay.AopSdk.Core.Domain
{
    public  class ResultCode
    {
         public const string SUCCESS = "10000";
         public const string INRROCESS = "10003";
         //业务处理失败:	具体失败原因参见接口返回的错误码    
         public const string FAIL = "40004";
         //业务出现未知错误或者系统异常: 如果支付接口返回，需要调用查询接口确认订单状态或者发起撤销
         public const string ERROR = "20000";
    }
        
    
}