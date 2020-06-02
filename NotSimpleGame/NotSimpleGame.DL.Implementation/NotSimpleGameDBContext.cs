using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NotSimpleGame.Entities;

namespace NotSimpleGame.DL.Implementation
{
    public class NotSimpleGameDBContext : DbContext
    {
        public NotSimpleGameDBContext(DbContextOptions<NotSimpleGameDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var lf = new LoggerFactory();
            lf.AddProvider(new MyLoggerProvider());
            optionsBuilder.UseLoggerFactory(lf);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var character1 = new CharacterEntity
            {
                Id = 1,
                Name = "Ельф",
                MoveSpeed = 100,
                JumpHeight = 100,
            };

            var character2 = new CharacterEntity
            {
                Id = 2,
                Name = "Гном",
                MoveSpeed = 80,
                JumpHeight = 120,
            };

            var character3 = new CharacterEntity
            {
                Id = 3,
                Name = "Маг",
                MoveSpeed = 120,
                JumpHeight = 80,
            };

            var character4 = new CharacterEntity
            {
                Id = 4,
                Name = "Воїн",
                MoveSpeed = 60,
                JumpHeight = 150,
            };

            var weapon1 = new WeaponEntity
            {
                Id = 1,
                Price = 0,
                Damage = 90,
                Distance = 200,
                ModelPath = "models/weapons/skin1.3ds",
                Name = "Стандартний молот",
                CharacterId = 2
            };

            var weapon2 = new WeaponEntity
            {
                Id = 2,
                Price = 0,
                Damage = 70,
                Distance = 300,
                ModelPath = "models/weapons/skin2.3ds",
                Name = "Стандартний лук",
                CharacterId = 1
            };

            var weapon3 = new WeaponEntity
            {
                Id = 3,
                Price = 0,
                Damage = 120,
                Distance = 100,
                ModelPath = "models/weapons/skin3.3ds",
                Name = "Стандартний меч",
                CharacterId = 4
            };

            var weapon4 = new WeaponEntity
            {
                Id = 4,
                Price = 0,
                Damage = 180,
                Distance = 50,
                ModelPath = "models/weapons/skin4.3ds",
                Name = "Стандартний посох",
                CharacterId = 3
            };

            var weapon5 = new WeaponEntity
            {
                Id = 5,
                Price = 300,
                Damage = 220,
                Distance = 50,
                ModelPath = "models/weapons/skin5.3ds",
                Name = "Золотий посох",
                CharacterId = 3
            };

            var skin1 = new SkinEntity
            {
                Id = 1,
                Price = 0,
                ModelPath = "models/skins/skin1.3ds",
                Name = "Стандартний вигляд",
                CharacterId = 2
            };

            var skin2 = new SkinEntity
            {
                Id = 2,
                Price = 0,
                ModelPath = "models/skins/skin2.3ds",
                Name = "Стандартний вигляд",
                CharacterId = 1
            };

            var skin3 = new SkinEntity
            {
                Id = 3,
                Price = 0,
                ModelPath = "models/skins/skin3.3ds",
                Name = "Стандартний вигляд",
                CharacterId = 4
            };

            var skin4 = new SkinEntity
            {
                Id = 4,
                Price = 0,
                ModelPath = "models/skins/skin4.3ds",
                Name = "Стандартний вигляд",
                CharacterId = 3
            };

            var skin5 = new SkinEntity
            {
                Id = 5,
                Price = 100,
                ModelPath = "models/skins/skin5.3ds",
                Name = "Маг з плащем",
                CharacterId = 3
            };

            var skin6 = new SkinEntity
            {
                Id = 6,
                Price = 300,
                ModelPath = "models/skins/skin6.3ds",
                Name = "Маг в костюмі",
                CharacterId = 3
            };

            var player = new PlayerEntity
            {
                Id = 1,
                Money = 500,
                CharacterId = 2,
                SkinId = 2,
                WeaponId = 2
            };

            modelBuilder.Entity<PlayerEntity>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Money).IsRequired();
                entity.HasOne<CharacterEntity>(p => p.Character).WithMany(p => p.Players).HasForeignKey(w => w.CharacterId);
                entity.HasOne<WeaponEntity>(p => p.Weapon).WithMany(p => p.Players).HasForeignKey(w => w.WeaponId);
                entity.HasOne<SkinEntity>(p => p.Skin).WithMany(p => p.Players).HasForeignKey(s => s.SkinId);
            });

            modelBuilder.Entity<CharacterEntity>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.MoveSpeed).IsRequired();
                entity.Property(e => e.JumpHeight).IsRequired();
            });

            modelBuilder.Entity<SkinEntity>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Price).IsRequired();
                entity.Property(e => e.ModelPath).IsRequired();
                entity.Property(e => e.CharacterId).IsRequired();
            });

            modelBuilder.Entity<WeaponEntity>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Damage).IsRequired();
                entity.Property(e => e.Price).IsRequired();
                entity.Property(e => e.ModelPath).IsRequired();
                entity.Property(e => e.CharacterId).IsRequired();
            });

            modelBuilder.Entity<PlayerEntity>().HasData(player);
            modelBuilder.Entity<CharacterEntity>().HasData(character1, character2, character3, character4);
            modelBuilder.Entity<WeaponEntity>().HasData(weapon1, weapon2, weapon3, weapon4, weapon5);
            modelBuilder.Entity<SkinEntity>().HasData(skin1, skin2, skin3, skin4, skin5, skin6);
        }
    }
}
