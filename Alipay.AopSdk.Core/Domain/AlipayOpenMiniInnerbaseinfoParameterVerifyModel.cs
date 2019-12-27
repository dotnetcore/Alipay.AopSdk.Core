using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoParameterVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerbaseinfoParameterVerifyModel : AopObject
    {
        /// <summary>
        /// 校验小程序基本信息枚举  APP_NAME 小程序名称  APP_ENGLISH_NAME 小程序英文名
        /// </summary>
        [XmlElement("verify_type")]
        public string VerifyType { get; set; }

        /// <summary>
        /// 小程序基本参数校验数据
        /// </summary>
        [XmlElement("verify_value")]
        public string VerifyValue { get; set; }
    }
}
