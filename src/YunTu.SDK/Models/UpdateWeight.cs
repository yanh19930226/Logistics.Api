using System;
using System.Collections.Generic;
using System.Text;

namespace YunTu.SDK.Models
{
    public class UpdateWeightRequest : BaseRequest<BaseResponse<UpdateWeightResponse>>
    {
        public UpdateWeightRequest(string code, string apiSecret) : base(code, apiSecret)
        {

        }
        public string OrderNumber { get; set; }
        public decimal Weight { get; set; }
        public override string Url => "http://oms.api.yunexpress.com/api/WayBill/UpdateWeight";
    }

    public class UpdateWeightResponse
    {
        public OrderWeight OrderWeight { get; set; }
    }

    public class OrderWeight
    {
        public string OrderNumber { get; set; }

        public string Status { get; set; }

        public string Remark { get; set; }
    }
}
