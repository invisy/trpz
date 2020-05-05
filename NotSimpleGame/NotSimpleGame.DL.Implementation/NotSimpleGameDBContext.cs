using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using NotSimpleGame.Entities;

namespace NotSimpleGame.DL.Implementation
{
    public class NotSimpleGameDBContext : DbContext 
    {
        public DbSet<PlayerEntity> Players { get; set; }
        public DbSet<WeaponEntity> Weapons { get; set; }
        public DbSet<SkinEntity> Skins { get; set; }

        public NotSimpleGameDBContext() : base()
        {
        }
    }
}
