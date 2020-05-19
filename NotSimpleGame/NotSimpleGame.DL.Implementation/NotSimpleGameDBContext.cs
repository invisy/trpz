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
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var player = new PlayerEntity
            {
                Id = 1,
                Money = 500
            };

            var weapon1 = new WeaponEntity
            {
                Id = 1,
                Price = 100,
                Damage = 90,
                Distance = 200,
                ModelPath = "models/weapons/skin1.3ds",
                Name = "Стандартний молот",
                Character = Entities.Enums.CharacterType.GNOME
            };

            var weapon2 = new WeaponEntity
            {
                Id = 2,
                Price = 100,
                Damage = 70,
                Distance = 300,
                ModelPath = "models/weapons/skin2.3ds",
                Name = "Стандартний лук",
                Character = Entities.Enums.CharacterType.ELF
            };

            var weapon3 = new WeaponEntity
            {
                Id = 3,
                Price = 100,
                Damage = 120,
                Distance = 100,
                ModelPath = "models/weapons/skin3.3ds",
                Name = "Стандартний меч",
                Character = Entities.Enums.CharacterType.WARRIOR
            };

            var weapon4 = new WeaponEntity
            {
                Id = 4,
                Price = 100,
                Damage = 180,
                Distance = 50,
                ModelPath = "models/weapons/skin4.3ds",
                Name = "Стандартний посох",
                Character = Entities.Enums.CharacterType.MAGICIAN
            };

            var skin1 = new SkinEntity
            {
                Id = 1,
                Price = 0,
                ModelPath = "models/skins/skin1.3ds",
                Name = "Стандартний вигляд",
                Character = Entities.Enums.CharacterType.GNOME
            };

            var skin2 = new SkinEntity
            {
                Id = 2,
                Price = 0,
                ModelPath = "models/skins/skin2.3ds",
                Name = "Стандартний вигляд",
                Character = Entities.Enums.CharacterType.ELF
            };

            var skin3 = new SkinEntity
            {
                Id = 3,
                Price = 0,
                ModelPath = "models/skins/skin3.3ds",
                Name = "Стандартний вигляд",
                Character = Entities.Enums.CharacterType.WARRIOR
            };

            var skin4 = new SkinEntity
            {
                Id = 4,
                Price = 0,
                ModelPath = "models/skins/skin4.3ds",
                Name = "Стандартний вигляд",
                Character = Entities.Enums.CharacterType.MAGICIAN
            };

            modelBuilder.Entity<PlayerEntity>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Money).IsRequired();
            });

            modelBuilder.Entity<SkinEntity>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Price).IsRequired();
                entity.Property(e => e.ModelPath).IsRequired();
                entity.Property(e => e.Character).IsRequired();
            });

            modelBuilder.Entity<WeaponEntity>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Damage).IsRequired();
                entity.Property(e => e.Price).IsRequired();
                entity.Property(e => e.ModelPath).IsRequired();
                entity.Property(e => e.Character).IsRequired();
            });

            modelBuilder.Entity<PlayerEntity>().HasData(player);
            modelBuilder.Entity<WeaponEntity>().HasData(weapon1, weapon2, weapon3, weapon4);
            modelBuilder.Entity<SkinEntity>().HasData(skin1, skin2, skin3, skin4);
        }
    }
}
