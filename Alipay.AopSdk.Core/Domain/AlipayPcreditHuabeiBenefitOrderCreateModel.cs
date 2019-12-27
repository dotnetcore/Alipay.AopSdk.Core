using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiBenefitOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiBenefitOrderCreateModel : AopObject
    {
        /// <summary>
        /// 支付宝业务单据号，在scene=BLUE_ARROW时候，必填，且值为先享协议号
        /// </summary>
        [XmlElement("alipay_biz_no")]
        public string AlipayBizNo { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 业务自定义参数，例如权益账务相关数据通过该字段传递  [      {        "key1": "value1"      },      {        "key2": "value2"      }    ]
        /// </summary>
        [XmlArray("biz_param")]
        [XmlArrayItem("key_value_pair")]
        public List<KeyValuePair> BizParam { get; set; }

        /// <summary>
        /// 商户端业务发生时间(yyyy-MM-dd HH:mm:ss)
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 是否需要多次触发。权益打包和多次触发场景会有为true，默认为false
        /// </summary>
        [XmlElement("need_repeat")]
        public bool NeedRepeat { get; set; }

        /// <summary>
        /// 权益商品id
        /// </summary>
        [XmlElement("out_goods_id")]
        public string OutGoodsId { get; set; }

        /// <summary>
        /// 商户本次操作的请求流水号，用于标示请求流水的唯一性，不能包含除中文、英文、数字以外的字符，需要保证在商户端不重复。支付宝侧用来做请求的幂等
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 权益商品sku_id，如果此项为空，会发放out_goods_id里面对应的所有sku
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 商户请求场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 是否立即触发发放。默认为false。蓝箭项目里面需要将此项设置为true
        /// </summary>
        [XmlElement("trigger_send")]
        public bool TriggerSend { get; set; }
    }
}
