using System;
using IdentityDimo.Areas.Identity.Data;
using IdentityDimo.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(IdentityDimo.Areas.Identity.IdentityHostingStartup))]
namespace IdentityDimo.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<IdentityDimoContext>(options =>
                    options.UseMySql(
                        context.Configuration.GetConnectionString("IdentityDimoContextConnection")));

                services.AddDefaultIdentity<IdentityDimoUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<IdentityDimoContext>();
            });
        }
    }
}