using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InsuranceClaimsLossTypes.Models;

namespace InsuranceClaimsLossTypes.Data
{
    public class InsuranceClaimsLossTypesContext : DbContext
    {
        public InsuranceClaimsLossTypesContext (DbContextOptions<InsuranceClaimsLossTypesContext> options)
            : base(options)
        {
        }

        public DbSet<InsuranceClaimsLossTypes.Models.LossTypeModel> LossTypeModel { get; set; }
    }
}
