using System;
using System.Collections.Generic;
using System.Text;

namespace YDH.Sdk.Models
{
    public class RemoveOrderReq : BaseRequest<RemoveOrderReqModel, BaseResponse<string>>
    {
        public RemoveOrderReq(RemoveOrderReqModel model) : base(model)
        {

        }
        public override string serviceMethod => "removeorder";
    }

    public class RemoveOrderReqModel
    {
        public string reference_no { get; set; }
    }
}
