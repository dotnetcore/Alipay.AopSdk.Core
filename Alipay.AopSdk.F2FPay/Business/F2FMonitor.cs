
namespace Alipay.AopSdk.F2FPay.Business
{
    /// <summary>
    /// F2FBiz 的摘要说明
    /// </summary>
    public class F2FMonitor
    {
        private F2FMonitor() { }

        public static IAlipayMonitor monitorClient = null;

        public static IAlipayMonitor CreateClientInstance(string monitorUrl, string appId, string merchant_private_key, string version,
                             string sign_type, string alipay_public_key, string charset)
        {
            if (monitorClient == null)
            {
                monitorClient = new AlipayMonitorImpl(monitorUrl, appId, merchant_private_key, "json", version,
                sign_type, alipay_public_key, charset);
            }
            return monitorClient;
        }

    }
}
