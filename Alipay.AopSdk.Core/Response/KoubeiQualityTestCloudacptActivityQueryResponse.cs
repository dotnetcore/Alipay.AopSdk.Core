using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// KoubeiQualityTestCloudacptActivityQueryResponse.
    /// </summary>
    public class KoubeiQualityTestCloudacptActivityQueryResponse : AopResponse
    {
        /// <summary>
        /// 活动列表
        /// </summary>
        [XmlArray("activity_list")]
        [XmlArrayItem("open_activity")]
        public List<OpenActivity> ActivityList { get; set; }
    }
}
