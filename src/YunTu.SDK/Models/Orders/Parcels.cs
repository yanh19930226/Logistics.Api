using System;
using System.Collections.Generic;
using System.Text;

namespace YunTu.SDK.Models.Orders
{
    public class Parcels
    {
        public string CName { get; set; }
        public string EName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public decimal UnitWeight { get; set; }
        public string CurrencyCode { get; set; }
    }
}
