using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayInsAutoAutoaftermarketAttachmentUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsAutoAutoaftermarketAttachmentUploadModel : AopObject
    {
        /// <summary>
        /// 蚂蚁业务单号(上传修理厂附件时，该字段可为空 ;上传维修中底漆照片时，传蚂蚁服务申请单号 )
        /// </summary>
        [XmlElement("ant_biz_id")]
        public string AntBizId { get; set; }

        /// <summary>
        /// CC_DEPOT_INFO_PICTURE("CC_DEPOT_INFO_PICTURE", "CC修理厂照片"), CC_CONSUME_REPAIR_CAR("CC_CONSUME_REPAIR_CAR", "CC核销修车"),;
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 扩展信息，json格式
        /// </summary>
        [XmlElement("extra")]
        public string Extra { get; set; }

        /// <summary>
        /// DEPOT_BANNER_PICTURE("DEPOT_BANNER_PICTURE", "修理厂广告图"), DEPOT_THUMBNAIL_PICTURE("DEPOT_THUMBNAIL_PICTURE", "修理厂缩略图"), REPAIRING_PICTURE("REPAIRING_PICTURE", "修理中影像"),
        /// </summary>
        [XmlElement("file_biz_code")]
        public string FileBizCode { get; set; }

        /// <summary>
        /// 文件内容
        /// </summary>
        [XmlElement("file_content")]
        public string FileContent { get; set; }

        /// <summary>
        /// 附件名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// AFTS("AFTS", "阿凡提系统"), OSS("OSS", "阿里云OSS");
        /// </summary>
        [XmlElement("file_store_type")]
        public string FileStoreType { get; set; }

        /// <summary>
        /// IMAGE("IMAGE", "图片"),  VIDEO("VIDEO", "视频"),  AUDIO("AUDIO", "音频"),  OTHER("OTHER", "其他");
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 外部业务单号(上传修理厂附件信息时传修理厂id, 上传修理厂底漆照片时传商户服务申请单号)
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        [XmlElement("path")]
        public string Path { get; set; }

        /// <summary>
        /// 文件上传时间
        /// </summary>
        [XmlElement("upload_time")]
        public string UploadTime { get; set; }
    }
}
