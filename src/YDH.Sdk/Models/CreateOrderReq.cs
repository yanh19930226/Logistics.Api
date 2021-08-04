using System;
using System.Collections.Generic;
using System.Text;

namespace YDH.Sdk.Models
{
    public class CreateOrderReq : BaseRequest<CreateOrderReqModel, BaseResponse<CreateOrderRes>>
    {
        public CreateOrderReq(CreateOrderReqModel model) : base(model)
        {

        }
        public override string serviceMethod => "createorder";
    }

    public class CreateOrderReqModel
    {
        /// <summary>
        /// 客户参考号
        /// </summary>
        public string reference_no { get; set; }
        /// <summary>
        /// 运输方式代码
        /// </summary>
        public string shipping_method { get; set; }
        /// <summary>
        /// 运输方式代码
        /// </summary>
        public string order_weight { get; set; }
        /// <summary>
        /// 发件人信息
        /// </summary>
        public Shipper shipper { get; set; }
        /// <summary>
        /// 收件人信息
        /// </summary>
        public Consignee consignee { get; set; }
        /// <summary>
        /// 海关申报信息
        /// </summary>
        public List<Invoice> invoice { get; set; }
    }

    /// <summary>
    /// 发件人信息
    /// </summary>
    public class Shipper
    {
        /// <summary>
        /// shipper_name
        /// </summary>
        public string shipper_name { get; set; }
        /// <summary>
        /// shipper_countrycode
        /// </summary>
        public string shipper_countrycode { get; set; }
        /// <summary>
        /// shipper_street
        /// </summary>
        public string shipper_street { get; set; }
        /// <summary>
        /// shipper_telephone
        /// </summary>
        public string shipper_telephone { get; set; }
        /// <summary>
        /// shipper_mobile
        /// </summary>
        public string shipper_mobile { get; set; }
    }

    /// <summary>
    /// 发件人信息
    /// </summary>
    public class Consignee
    {
        /// <summary>
        /// 收件人姓名
        /// </summary>
        public string consignee_name { get; set; }
        /// <summary>
        /// 收件人国家二字代码
        /// </summary>
        public string consignee_countrycode { get; set; }
        /// <summary>
        /// 收件人省
        /// </summary>
        public string consignee_province { get; set; }
        /// <summary>
        /// 收件人城市
        /// </summary>
        public string consignee_city { get; set; }
        /// <summary>
        /// 收件人地址
        /// </summary>
        public string consignee_street { get; set; }
        /// <summary>
        /// 收件人邮编
        /// </summary>
        public string consignee_postcode { get; set; }
        /// <summary>
        /// 收件人电话
        /// </summary>
        public string consignee_telephone { get; set; }
        /// <summary>
        /// 收件人手机
        /// </summary>
        public string consignee_mobile { get; set; }
        /// <summary>
        /// 税号
        /// </summary>
        public string consignee_tariff { get; set; }
    }
    /// <summary>
    /// 海关申报信息
    /// </summary>
    public class Invoice
    {
        /// <summary>
        /// 英文品名
        /// </summary>
        public string invoice_enname { get; set; }
        /// <summary>
        /// 中文品名
        /// </summary>
        public string invoice_cnname { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public string invoice_quantity { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public string invoice_unitcharge { get; set; }
        /// <summary>
        /// 收件人地址
        /// </summary>
        public string consignee_street { get; set; }
        /// <summary>
        /// 收件人邮编
        /// </summary>
        public string consignee_postcode { get; set; }
    }
    public class CreateOrderRes
    {
        /// <summary>
        /// order_id
        /// </summary>
        public string order_id { get; set; }
        /// <summary>
        /// refrence_no
        /// </summary>
        public string refrence_no { get; set; }
        /// <summary>
        /// shipping_method_no
        /// </summary>
        public string shipping_method_no { get; set; }
        /// <summary>
        /// channel_hawbcode
        /// </summary>
        public string channel_hawbcode { get; set; }
    }
}
