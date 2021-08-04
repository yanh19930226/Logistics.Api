using System;
using System.Collections.Generic;
using System.Text;

namespace YDH.Sdk.Models
{
    public class GetNewLabelReq : BaseRequest<GetNewLabelReqModel, BaseResponse<List<GetNewLabelRes>>>
    {
        public GetNewLabelReq(GetNewLabelReqModel model) : base(model)
        {

        }
        public override string serviceMethod => "getnewlabel";
    }

    public class GetNewLabelReqModel
    {
        public configInfo configInfo { get; set; }
        public List<reference> listorder { get; set; }

    }
    public class reference
    {
        public string reference_no { get; set; }
    }


    public class configInfo
    {
        public string lable_file_type { get; set; }
        public string lable_paper_type { get; set; }

        public string lable_content_type { get; set; }

        public additional_info additional_info { get; set; }

    }

    public class additional_info
    {
        public string lable_print_invoiceinfo { get; set; }
        public string lable_print_buyerid { get; set; }

        public string lable_print_datetime { get; set; }
        public string lable_prcustomsdeclaration_print_actualweightint_buyerid { get; set; }
    }
    public class GetNewLabelRes
    {
        public string lable_file_type { get; set; }
        public string lable_file { get; set; }
        //public List<Data> data { get; set; }

    }
    public class Data
    {
        public string lable_file_type { get; set; }
        public string lable_file { get; set; }
    }
}
