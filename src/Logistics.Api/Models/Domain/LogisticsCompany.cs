using Core.Data.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Api.Models.Domain
{
    /// <summary>
    /// 物流公司
    /// </summary>
    public class LogisticsCompany : Entity
    {
        public string Name { get; set; }
    }
}
