﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NotSimpleGame.DL.Implementation;

namespace NotSimpleGame.DL.Implementation.Migrations
{
    [DbContext(typeof(NotSimpleGameDBContext))]
    [Migration("20200529015402_PlayerForeignKeyNamesUpdate")]
    partial class PlayerForeignKeyNamesUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NotSimpleGame.Entities.PlayerEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Character")
                        .HasColumnType("int");

                    b.Property<long>("Money")
                        .HasColumnType("bigint");

                    b.Property<int>("SkinId")
                        .HasColumnType("int");

                    b.Property<int>("WeaponId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SkinId");

                    b.HasIndex("WeaponId");

                    b.ToTable("PlayerEntity");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Character = 1,
                            Money = 500L,
                            SkinId = 2,
                            WeaponId = 2
                        });
                });

            modelBuilder.Entity("NotSimpleGame.Entities.SkinEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Character")
                        .HasColumnType("int");

                    b.Property<string>("ModelPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("SkinEntity");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Character = 2,
                            ModelPath = "models/skins/skin1.3ds",
                            Name = "Стандартний вигляд",
                            Price = 0L
                        },
                        new
                        {
                            Id = 2,
                            Character = 1,
                            ModelPath = "models/skins/skin2.3ds",
                            Name = "Стандартний вигляд",
                            Price = 0L
                        },
                        new
                        {
                            Id = 3,
                            Character = 4,
                            ModelPath = "models/skins/skin3.3ds",
                            Name = "Стандартний вигляд",
                            Price = 0L
                        },
                        new
                        {
                            Id = 4,
                            Character = 3,
                            ModelPath = "models/skins/skin4.3ds",
                            Name = "Стандартний вигляд",
                            Price = 0L
                        },
                        new
                        {
                            Id = 5,
                            Character = 3,
                            ModelPath = "models/skins/skin5.3ds",
                            Name = "Маг з плащем",
                            Price = 100L
                        },
                        new
                        {
                            Id = 6,
                            Character = 3,
                            ModelPath = "models/skins/skin6.3ds",
                            Name = "Маг в костюмі",
                            Price = 300L
                        });
                });

            modelBuilder.Entity("NotSimpleGame.Entities.WeaponEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Character")
                        .HasColumnType("int");

                    b.Property<float>("Damage")
                        .HasColumnType("real");

                    b.Property<float>("Distance")
                        .HasColumnType("real");

                    b.Property<string>("ModelPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("WeaponEntity");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Character = 2,
                            Damage = 90f,
                            Distance = 200f,
                            ModelPath = "models/weapons/skin1.3ds",
                            Name = "Стандартний молот",
                            Price = 0L
                        },
                        new
                        {
                            Id = 2,
                            Character = 1,
                            Damage = 70f,
                            Distance = 300f,
                            ModelPath = "models/weapons/skin2.3ds",
                            Name = "Стандартний лук",
                            Price = 0L
                        },
                        new
                        {
                            Id = 3,
                            Character = 4,
                            Damage = 120f,
                            Distance = 100f,
                            ModelPath = "models/weapons/skin3.3ds",
                            Name = "Стандартний меч",
                            Price = 0L
                        },
                        new
                        {
                            Id = 4,
                            Character = 3,
                            Damage = 180f,
                            Distance = 50f,
                            ModelPath = "models/weapons/skin4.3ds",
                            Name = "Стандартний посох",
                            Price = 0L
                        },
                        new
                        {
                            Id = 5,
                            Character = 3,
                            Damage = 220f,
                            Distance = 50f,
                            ModelPath = "models/weapons/skin5.3ds",
                            Name = "Золотий посох",
                            Price = 300L
                        });
                });

            modelBuilder.Entity("NotSimpleGame.Entities.PlayerEntity", b =>
                {
                    b.HasOne("NotSimpleGame.Entities.SkinEntity", null)
                        .WithMany()
                        .HasForeignKey("SkinId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NotSimpleGame.Entities.WeaponEntity", null)
                        .WithMany()
                        .HasForeignKey("WeaponId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
