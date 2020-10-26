using System;
using System.Collections.Generic;
using System.Text;

namespace YunTu.SDK.Models
{

    public class CountryRequest:BaseRequest<BaseResponse<List<CountryReponse>>>
    {
        public CountryRequest(string code, string apiSecret) : base(code, apiSecret)
        {

        }
        public override string Url=> "http://oms.api.yunexpress.com/api/Common/GetCountry";
    }

    public class CountryReponse 
    {
        public string CountryCode { get; set; }
        public string EName { get; set; }
        public string CName { get; set; }
    }
}
