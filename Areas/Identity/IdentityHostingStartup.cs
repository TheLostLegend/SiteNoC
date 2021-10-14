using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WEB_953502_Архиреенко.Data;

[assembly: HostingStartup(typeof(WEB_953502_Архиреенко.Areas.Identity.IdentityHostingStartup))]
namespace WEB_953502_Архиреенко.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<WEB_953502_АрхиреенкоContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("WEB_953502_АрхиреенкоContextConnection")));
            });
        }
    }
}