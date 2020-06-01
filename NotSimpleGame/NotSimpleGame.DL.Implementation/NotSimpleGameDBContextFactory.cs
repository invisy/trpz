using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace NotSimpleGame.DL.Implementation
{
    public class NotSimpleGameDBContextFactory : IDesignTimeDbContextFactory<NotSimpleGameDBContext>
    {
        public NotSimpleGameDBContext CreateDbContext(string[] args)
        {
            var connectionString = Environment.GetEnvironmentVariable("EFCORETOOLSDB");
            if (string.IsNullOrEmpty(connectionString))
                throw new InvalidOperationException("The connection string was not set " +
                "in the 'EFCORETOOLSDB' environment variable.");

            var options = new DbContextOptionsBuilder<NotSimpleGameDBContext>()
               .UseSqlServer(connectionString)
               .Options;
            return new NotSimpleGameDBContext(options);
        }
    }
}
