using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorStationQueryResponse.
    /// </summary>
    public class AlipayCommerceCityfacilitatorStationQueryResponse : AopResponse
    {
        /// <summary>
        /// 支持设为起点的站点列表
        /// </summary>
        [XmlArray("support_starts")]
        [XmlArrayItem("station_detail_info")]
        public List<StationDetailInfo> SupportStarts { get; set; }
    }
}
