using Core.Data.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Api.Models.Domain
{
    public class LogisticsCompanyCountryConfig:Entity
    {

        /// <summary>
        /// 物流公司Id
        /// </summary>
        public long LogisticsCompanyId { get; set; }

        public LogisticsCompany LogisticsCompany { get; set; }
    }
}
