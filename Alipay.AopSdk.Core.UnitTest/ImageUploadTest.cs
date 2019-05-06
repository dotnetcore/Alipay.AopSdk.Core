using System.Net.Http.Headers;
using System.Threading.Tasks;
using Alipay.AopSdk.Core.Request;
using Alipay.AopSdk.Core.Response;
using Alipay.AopSdk.Core.Util;
using Xunit;
using Xunit.Sdk;

namespace Alipay.AopSdk.Core.UnitTest
{
    public class ImageUploadTest
    {
        [Fact]
        public async Task ImageUpload()
        {
            var client = new DefaultAopClient("https://openapi.alipaydev.com/gateway.do", "", "", "json", "1.0",
                "RSA2", "", "UTF-8", false);
            AlipayOfflineMaterialImageUploadRequest request = new AlipayOfflineMaterialImageUploadRequest();
            request.ImageType = "jpg";
            request.ImageName = "logo图片";
            FileItem imageContent = new FileItem("edgeless.jpg");

            request.ImageContent = imageContent;
            request.ImagePid = "201901101551";
            AlipayOfflineMaterialImageUploadResponse response = await client.ExecuteAsync(request);
        }
    }
}