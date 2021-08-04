using System;
using System.Collections.Generic;
using System.Text;

namespace YDH.Sdk.Models
{
    public class GetTrackingNumberReq : BaseRequest<GetTrackingNumberReqModel, BaseResponse<GetTrackingNumberRes>>
    {
        public GetTrackingNumberReq(GetTrackingNumberReqModel model) : base(model)
        {

        }
        public override string serviceMethod => "gettrackingnumber";
    }


    public class GetTrackingNumberReqModel
    {
        public string reference_no { get; set; }
    }


    public class GetTrackingNumberRes
    {
        public string reference_no { get; set; }

        public string shipping_method_no { get; set; }

        public string channel_hawbcode { get; set; }

    }
}
