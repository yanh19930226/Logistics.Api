using System;
using System.Collections.Generic;
using System.Text;

namespace YDH.Sdk.Models
{
    public class GetTrackReq : BaseRequest<GetTrackReqModel, BaseResponse<GetTrackRes>>
    {
        public GetTrackReq(GetTrackReqModel model) : base(model)
        {

        }
        public override string serviceMethod => "gettrack";
    }

    public class GetTrackReqModel
    {
        public string tracking_number { get; set; }
    }

    public class GetTrackRes
    {
        public string server_hawbcode { get; set; }
        public string destination_country { get; set; }
        public string track_status { get; set; }
        public string track_status_name { get; set; }
        public string signatory_name { get; set; }
        public List<Detail> details { get; set; }
    }

    public class Detail
    {
        public string track_occur_date { get; set; }
        public string track_location { get; set; }
        public string track_description { get; set; }
        public string track_description_en { get; set; }
    }
}
