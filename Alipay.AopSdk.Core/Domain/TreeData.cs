using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// TreeData Data Structure.
    /// </summary>
    [Serializable]
    public class TreeData : AopObject
    {
        /// <summary>
        /// 是否合种。true：是合种，false：不是合种
        /// </summary>
        [XmlElement("cooperation")]
        public bool Cooperation { get; set; }

        /// <summary>
        /// 当前分类下已种植树数量，如：合种胡杨1棵，个人种植胡杨1棵
        /// </summary>
        [XmlElement("num")]
        public long Num { get; set; }

        /// <summary>
        /// 树种别名
        /// </summary>
        [XmlElement("tree_alias")]
        public string TreeAlias { get; set; }

        /// <summary>
        /// 树种类型，保护地【RESERVE】还是树苗【TREE】
        /// </summary>
        [XmlElement("tree_type")]
        public string TreeType { get; set; }
    }
}
