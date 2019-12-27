using System.Collections.Generic;
using System.Xml.Serialization;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// KoubeiCraftsmanDataWorkCreateResponse.
    /// </summary>
    public class KoubeiCraftsmanDataWorkCreateResponse : AopResponse
    {
        /// <summary>
        /// 作品id
        /// </summary>
        [XmlArray("works")]
        [XmlArrayItem("craftsman_work_out_id_open_model")]
        public List<CraftsmanWorkOutIdOpenModel> Works { get; set; }
    }
}
