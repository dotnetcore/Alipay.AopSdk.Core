using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvTemplateVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogMmtcaftscvTemplateVerifyModel : AopObject
    {
        /// <summary>
        /// 商品Id列表
        /// </summary>
        [XmlArray("algorithm_goods_ids")]
        [XmlArrayItem("string")]
        public List<string> AlgorithmGoodsIds { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("good_count")]
        public long GoodCount { get; set; }

        /// <summary>
        /// 机型编号
        /// </summary>
        [XmlElement("machine_type_id")]
        public string MachineTypeId { get; set; }

        /// <summary>
        /// 场景关联id
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 模板编号
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
