using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// SmartAutomatScene Data Structure.
    /// </summary>
    [Serializable]
    public class SmartAutomatScene : AopObject
    {
        /// <summary>
        /// 自助售货机一级场景，可取值如下：  SCHOOL  MALL  STATION  FACTORY  COMMUNITY  OFFICE  HOSPITAL  GOVERNMENT  SCENIC_SPOT  OTHERS
        /// </summary>
        [XmlElement("level_1")]
        public string Level1 { get; set; }

        /// <summary>
        /// 自助售货机二级场景，可取值如下(不同的一级场景下，可取值不同，详见scene说明)：  001  002  003  004  005  006  007
        /// </summary>
        [XmlElement("level_2")]
        public string Level2 { get; set; }
    }
}
