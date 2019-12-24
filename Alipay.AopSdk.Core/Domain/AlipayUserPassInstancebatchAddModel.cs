using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayUserPassInstancebatchAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserPassInstancebatchAddModel : AopObject
    {
        /// <summary>
        /// alipass实例操作信息列表。
        /// </summary>
        [XmlArray("instance_op_list")]
        [XmlArrayItem("alipass_instance_op_info")]
        public List<AlipassInstanceOpInfo> InstanceOpList { get; set; }

        /// <summary>
        /// 支付宝用户识别信息，需结合大礼包发券组件使用，对接文档：https://docs.open.alipay.com/199/sy3hs4。
        /// </summary>
        [XmlElement("recognition_info")]
        public string RecognitionInfo { get; set; }

        /// <summary>
        /// 对象识别类型，2表示按UserId发券。
        /// </summary>
        [XmlElement("recognition_type")]
        public string RecognitionType { get; set; }
    }
}
