using System.IO;
using System.Text;
using Xunit;

namespace Alipay.AopSdk.Core.UnitTest
{
    public class TestImage
    {
        [Fact]
        public void Fact1()
        {
            IAopClient client = GetAlipayClient();
            AlipayMobilePublicMultiMediaDownloadRequest req = new AlipayMobilePublicMultiMediaDownloadRequest();
            
            string path = "i:/1.jpg";
            if(File.Exists(path)){
                File.Delete(path);
            }
            FileStream fs = new FileStream(path, FileMode.CreateNew);
            req.stream = fs;
	        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

			string mediaId = "L21pZnMvVDFQV3hYWGJKWFhYYUNucHJYP3Q9YW13ZiZ4c2lnPTU0MzRhYjg1ZTZjNWJmZTMxZGJiNjIzNDdjMzFkNzkw575";
            req.BizContent = "{\"mediaId\":\""+mediaId+"\"}";

            AlipayMobilePublicMultiMediaDownloadResponse res = client.Execute(req);
            System.Console.WriteLine("-------------公众号菜单查询-------------");

            System.Console.WriteLine("Body:" + res.Body);
        }

        private IAopClient GetAlipayClient()
        {
            //支付宝网关地址
            // -----开发环境地址-----
            string serverUrl = "https://openfile.alipay.com/chat/multimedia.do";
            
            // -----沙箱地址-----
            // string serverUrl = "http://openapi.alipaydev.com/gateway.do";
            
            // -----线上地址-----
            // string serverUrl = "https://openapi.alipay.com/gateway.do";
            
            //应用ID
            string appId = "2013092500031084";
			//商户私钥
			string privateKeyPem = "aop-sandbox-RSA-private-c#.pem";

            IAopClient client = new AlipayMobilePublicMultiMediaClient(serverUrl, appId, privateKeyPem, "json","GBK");

            return client;
        }
    }
}
