using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
    /// <summary>
    /// ZolozAuthenticationCustomerAnonymousfacesearchMatchResponse.
    /// </summary>
    public class ZolozAuthenticationCustomerAnonymousfacesearchMatchResponse : AopResponse
    {
        /// <summary>
        /// 搜索到的人脸候选集
        /// </summary>
        [XmlArray("candidatelist")]
        [XmlArrayItem("face_search_user_info")]
        public List<FaceSearchUserInfo> Candidatelist { get; set; }

        /// <summary>
        /// 人脸搜索找到的用户
        /// </summary>
        [XmlElement("foundface")]
        public FaceSearchUserInfo Foundface { get; set; }

        /// <summary>
        /// 返回详细码
        /// </summary>
        [XmlElement("retcodesub")]
        public string Retcodesub { get; set; }

        /// <summary>
        /// 操作成功
        /// </summary>
        [XmlElement("retmessagesub")]
        public string Retmessagesub { get; set; }

        /// <summary>
        /// 返回账户信息:merchantid/merchantuid
        /// </summary>
        [XmlArray("userinfolist")]
        [XmlArrayItem("face_search_anonymous_user_info")]
        public List<FaceSearchAnonymousUserInfo> Userinfolist { get; set; }
    }
}
