using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Web_953503_Alshanikov.Data;
using Web_953503_Alshanikov.Entities;

[assembly: HostingStartup(typeof(Web_953503_Alshanikov.Areas.Identity.IdentityHostingStartup))]
namespace Web_953503_Alshanikov.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {



            });
        }
    }
}