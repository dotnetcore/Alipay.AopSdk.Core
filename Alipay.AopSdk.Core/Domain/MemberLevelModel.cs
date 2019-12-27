using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// MemberLevelModel Data Structure.
    /// </summary>
    [Serializable]
    public class MemberLevelModel : AopObject
    {
        /// <summary>
        /// 模板会员下的等级编号
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 会员级别对应icon， 通过接口（alipay.offline.material.image.upload）上传图片
        /// </summary>
        [XmlElement("icon_img")]
        public string IconImg { get; set; }

        /// <summary>
        /// 必须从0开始有序  会员模板下的等级，比如会员模板下有普通会员，中级会员，高级会员三种等级，则分别对应0，1，2
        /// </summary>
        [XmlElement("level")]
        public long Level { get; set; }

        /// <summary>
        /// 会员模板下会员等级的展示名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 栏位信息
        /// </summary>
        [XmlArray("view_column_infos")]
        [XmlArrayItem("view_column_info_model")]
        public List<ViewColumnInfoModel> ViewColumnInfos { get; set; }

        /// <summary>
        /// 模板样式信息
        /// </summary>
        [XmlElement("view_style_info")]
        public ViewStyleInfoModel ViewStyleInfo { get; set; }
    }
}
