using System;
using System.Collections.Generic;
using System.Text;

namespace YunTu.SDK.Models
{

    public class CountryRequest:BaseRequest<CountryReponse>
    {
        public string CountryCodes { get; set; }
        public string EName { get; set; }
        public string CName { get; set; }
        public override string Url { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public class CountryReponse 
    {
        public string CountryCodes { get; set; }
        public string EName { get; set; }
        public string CName { get; set; }
    }
}
