using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// ExerciseUserMappingDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ExerciseUserMappingDTO : AopObject
    {
        /// <summary>
        /// 健身用户id
        /// </summary>
        [XmlElement("fitness_id")]
        public string FitnessId { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}
