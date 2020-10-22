using Logistics.Api.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Api.Models.EntityConfiguration
{
    public class LogisticsCompanyCfg : IEntityTypeConfiguration<LogisticsCompany>
    {
        public void Configure(EntityTypeBuilder<LogisticsCompany> builder)
        {
        }
    }
}
