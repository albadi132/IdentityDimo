using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityDimo.Areas.Identity.Data;

using IdentityDimo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityDimo.Data
{
    public class IdentityDimoContext : IdentityDbContext<IdentityDimoUser>
    {
        public IdentityDimoContext(DbContextOptions<IdentityDimoContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Categorys> Categorys { get; set; }
    }
}
