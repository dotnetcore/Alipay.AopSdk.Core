using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// BoothContentInfoModel Data Structure.
    /// </summary>
    [Serializable]
    public class BoothContentInfoModel : AopObject
    {
        /// <summary>
        /// 展台名称
        /// </summary>
        [XmlElement("booth")]
        public string Booth { get; set; }

        /// <summary>
        /// 内容信息列表
        /// </summary>
        [XmlArray("content_info_list")]
        [XmlArrayItem("content_info_model")]
        public List<ContentInfoModel> ContentInfoList { get; set; }
    }
}
