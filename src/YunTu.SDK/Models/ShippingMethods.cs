using System;
using System.Collections.Generic;
using System.Text;

namespace YunTu.SDK.Models
{
    public class ShippingMethodsRequest : BaseRequest<BaseResponse<List<ShippingMethodsReponse>>>
    {
        public ShippingMethodsRequest(string code, string apiSecret) : base(code, apiSecret)
        {

        }
        /// <summary>
        /// 国家简码,未填写国家代表查询所有运
        /// </summary>
        public string CountryCode { get; set; }
        public override string Url => "http://oms.api.yunexpress.com/api/Common/GetShippingMethods";
    }

    public class ShippingMethodsReponse
    {
        /// <summary>
        /// 运输方式代号
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 运输方式英文名称
        /// </summary>
        public string EName { get; set; }
        /// <summary>
        /// 运输方式中文名称
        /// </summary>
        public string CName { get; set; }
        /// <summary>
        /// 是否带跟踪号
        /// </summary>
        public string HasTrackingNumber { get; set; }
        /// <summary>
        /// 运输方式显示名称
        /// </summary>
        public string DisplayName { get; set; }
    }
}
