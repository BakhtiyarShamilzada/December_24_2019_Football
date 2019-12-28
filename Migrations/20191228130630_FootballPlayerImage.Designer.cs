﻿// <auto-generated />
using System;
using December_24_2019_Football.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace December_24_2019_Football.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20191228130630_FootballPlayerImage")]
    partial class FootballPlayerImage
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("December_24_2019_Football.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Carts");

                    b.HasData(
                        new { Id = 1, Name = "Red" },
                        new { Id = 2, Name = "Yellow" }
                    );
                });

            modelBuilder.Entity("December_24_2019_Football.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new { Id = 1, Name = "Mexico" },
                        new { Id = 2, Name = "Brazil" }
                    );
                });

            modelBuilder.Entity("December_24_2019_Football.Models.FootballCart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CartId");

                    b.Property<DateTime>("Date");

                    b.Property<int>("FootballPlayerId");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("FootballPlayerId");

                    b.ToTable("FootballCarts");

                    b.HasData(
                        new { Id = 1, CartId = 1, Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), FootballPlayerId = 1 },
                        new { Id = 2, CartId = 2, Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), FootballPlayerId = 2 },
                        new { Id = 3, CartId = 1, Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), FootballPlayerId = 3 },
                        new { Id = 4, CartId = 2, Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), FootballPlayerId = 4 },
                        new { Id = 5, CartId = 1, Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), FootballPlayerId = 5 },
                        new { Id = 6, CartId = 2, Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), FootballPlayerId = 6 },
                        new { Id = 7, CartId = 1, Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), FootballPlayerId = 7 },
                        new { Id = 8, CartId = 2, Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), FootballPlayerId = 8 }
                    );
                });

            modelBuilder.Entity("December_24_2019_Football.Models.FootballPlayer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Image");

                    b.Property<string>("Lastname")
                        .HasMaxLength(50);

                    b.Property<int>("PositionId");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.ToTable("FootballPlayers");

                    b.HasData(
                        new { Id = 1, Age = 25, Firstname = "Messi", Lastname = "Lionel", PositionId = 1 },
                        new { Id = 2, Age = 27, Firstname = "Ronaldo", Lastname = "Cristiano", PositionId = 2 },
                        new { Id = 3, Age = 32, Firstname = "Xavi", Lastname = "Xavi", PositionId = 3 },
                        new { Id = 4, Age = 28, Firstname = "Iniesta", Lastname = "Andres", PositionId = 4 },
                        new { Id = 5, Age = 31, Firstname = "Ibrahimovic", Lastname = "Zlatan", PositionId = 5 },
                        new { Id = 6, Age = 26, Firstname = "Falcao", Lastname = "Radamel", PositionId = 6 },
                        new { Id = 7, Age = 29, Firstname = "Persie", Lastname = "Robin van", PositionId = 7 },
                        new { Id = 8, Age = 33, Firstname = "Pirlo", Lastname = "Andrea", PositionId = 8 }
                    );
                });

            modelBuilder.Entity("December_24_2019_Football.Models.FootballPlayerGameTime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FootballPlayerId");

                    b.Property<int>("GameTimeId");

                    b.HasKey("Id");

                    b.HasIndex("FootballPlayerId");

                    b.HasIndex("GameTimeId");

                    b.ToTable("FootballPlayerGameTimes");

                    b.HasData(
                        new { Id = 1, FootballPlayerId = 1, GameTimeId = 1 },
                        new { Id = 2, FootballPlayerId = 2, GameTimeId = 2 }
                    );
                });

            modelBuilder.Entity("December_24_2019_Football.Models.GameTime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int>("StadiumId");

                    b.Property<int>("TeamId");

                    b.HasKey("Id");

                    b.HasIndex("StadiumId");

                    b.HasIndex("TeamId");

                    b.ToTable("GameTimes");

                    b.HasData(
                        new { Id = 1, Date = new DateTime(2019, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), StadiumId = 1, TeamId = 1 },
                        new { Id = 2, Date = new DateTime(2019, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), StadiumId = 2, TeamId = 2 }
                    );
                });

            modelBuilder.Entity("December_24_2019_Football.Models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Positions");

                    b.HasData(
                        new { Id = 1, Name = "Goalkeeper" },
                        new { Id = 2, Name = "Full-backs" },
                        new { Id = 3, Name = "Centre-Backs" },
                        new { Id = 4, Name = "Sweeper" },
                        new { Id = 5, Name = "Central Midfield" },
                        new { Id = 6, Name = "Wide Midfield" },
                        new { Id = 7, Name = "Striker" },
                        new { Id = 8, Name = "Behind the Striker" }
                    );
                });

            modelBuilder.Entity("December_24_2019_Football.Models.Stadium", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Stadiums");

                    b.HasData(
                        new { Id = 1, Address = "‎1 Scarlet Knight Way", Name = "Infinity Ring" },
                        new { Id = 2, Address = "Jake Nevin Field House", Name = "Paragon Field" }
                    );
                });

            modelBuilder.Entity("December_24_2019_Football.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Teams");

                    b.HasData(
                        new { Id = 1, CountryId = 1, Name = "Amigos" },
                        new { Id = 2, CountryId = 1, Name = "Mamacitas" },
                        new { Id = 3, CountryId = 2, Name = "Liverpool FC" },
                        new { Id = 4, CountryId = 2, Name = "Manchester City" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("December_24_2019_Football.Models.FootballCart", b =>
                {
                    b.HasOne("December_24_2019_Football.Models.Cart", "Cart")
                        .WithMany("FootballCarts")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("December_24_2019_Football.Models.FootballPlayer", "FootballPlayer")
                        .WithMany("FootballCarts")
                        .HasForeignKey("FootballPlayerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("December_24_2019_Football.Models.FootballPlayer", b =>
                {
                    b.HasOne("December_24_2019_Football.Models.Position", "Position")
                        .WithMany("FootballPlayers")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("December_24_2019_Football.Models.FootballPlayerGameTime", b =>
                {
                    b.HasOne("December_24_2019_Football.Models.FootballPlayer", "FootballPlayer")
                        .WithMany("FootballPlayerGameTimes")
                        .HasForeignKey("FootballPlayerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("December_24_2019_Football.Models.GameTime", "GameTime")
                        .WithMany("FootballPlayerGameTimes")
                        .HasForeignKey("GameTimeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("December_24_2019_Football.Models.GameTime", b =>
                {
                    b.HasOne("December_24_2019_Football.Models.Stadium", "Stadium")
                        .WithMany("GameTimes")
                        .HasForeignKey("StadiumId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("December_24_2019_Football.Models.Team", "Team")
                        .WithMany("GameTimes")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("December_24_2019_Football.Models.Team", b =>
                {
                    b.HasOne("December_24_2019_Football.Models.Country", "Country")
                        .WithMany("Teams")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
