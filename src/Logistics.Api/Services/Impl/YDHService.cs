using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Api.Services.Impl
{
    public class YDHService : ILogisticsService
    {
        public void Create(erp.dbmodel.OrderLogistics logistics, Dictionary<erp.dbmodel.OrderDetailed, erp.dbmodel.GoodsSku> itemDic)
        {
            throw new NotImplementedException();
        }

        public void Dictionary<>(bool 1, IList<OrderTracking> 2, Track 3, (string trackingNumber, object) 4)
        {
            throw new NotImplementedException();
        }

        public decimal GetEvaluateShippingFee(string countryCode, decimal weight, string code)
        {
            throw new NotImplementedException();
        }

        public ShippingFee GetRealShippingFee(string trackingNumber)
        {
            throw new NotImplementedException();
        }
    }
}
