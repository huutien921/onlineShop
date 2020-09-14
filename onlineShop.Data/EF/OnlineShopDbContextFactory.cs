using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace onlineShop.Data.EF
{
    public class OnlineShopDbContextFactory : IDesignTimeDbContextFactory<OnlineShopDbContext>
    {
        public OnlineShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
              .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("onlineShopDb");

            var optionsBuilder = new DbContextOptionsBuilder<OnlineShopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new OnlineShopDbContext(optionsBuilder.Options);
        }
    }
}
