using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace zingmp3Solution.Data.EF
{
    public class ZingMp3DbContextFactory : IDesignTimeDbContextFactory<ZingMp3DbContext>
    {
        public ZingMp3DbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("ZingMp3SolutionDb");
            var optionBuilder = new DbContextOptionsBuilder<ZingMp3DbContext>();
            optionBuilder.UseSqlServer(connectionString);
            return new ZingMp3DbContext(optionBuilder.Options);

        }
    }
}
