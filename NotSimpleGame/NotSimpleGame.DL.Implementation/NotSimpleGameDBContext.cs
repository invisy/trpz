using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using NotSimpleGame.Entities;

namespace NotSimpleGame.DL.Implementation
{
    public class NotSimpleGameDBContext : DbContext 
    {
        public NotSimpleGameDBContext() : base()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
