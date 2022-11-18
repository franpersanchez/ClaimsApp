using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VehicleClaimsApplication.Models;

namespace ClaimsApp.Data
{
    public class ClaimsAppContext : DbContext
    {
        public ClaimsAppContext (DbContextOptions<ClaimsAppContext> options)
            : base(options)
        {
        }

        public DbSet<VehicleClaimsApplication.Models.Owner> Owner { get; set; } = default!;

        public DbSet<VehicleClaimsApplication.Models.Vehicle> Vehicle { get; set; }

        public DbSet<VehicleClaimsApplication.Models.Claim> Claim { get; set; }
    }
}
