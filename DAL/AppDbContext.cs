using December_24_2019_Football.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace December_24_2019_Football.DAL
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
           
        }
        public DbSet<Position> Positions { get; set; }

        public DbSet<FootballPlayer> FootballPlayers { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<PositionType> PositionTypes { get; set; }

        public DbSet<FootballerPosition> FootballerPositions { get; set; }

        public DbSet<GameTime> GameTimes { get; set; }

        public DbSet<FootballCart> FootballCarts { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Stadium> Stadiums { get; set; }

        public DbSet<FootballPlayerGameTime> FootballPlayerGameTimes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity(typeof(Position)).HasData(
                new Position { Id = 1, Name = "Goalkeeper" },
                new Position { Id = 2, Name = "Full-backs" },
                new Position { Id = 3, Name = "Centre-Backs" },
                new Position { Id = 4, Name = "Sweeper" },
                new Position { Id = 5, Name = "Central Midfield" },
                new Position { Id = 6, Name = "Wide Midfield" },
                new Position { Id = 7, Name = "Striker" },
                new Position { Id = 8, Name = "Behind the Striker" }
            );

            builder.Entity(typeof(Country)).HasData(
               new Country { Id = 1, Name = "Mexico" },
               new Country { Id = 2, Name = "Brazil" }
           );

            builder.Entity(typeof(Team)).HasData(
              new Team { Id = 1, Name = "Real madrid", CountryId = 1 },
              new Team { Id = 2, Name = "SV werder bremen", CountryId = 2 }
          );

            builder.Entity(typeof(FootballPlayer)).HasData(
               new FootballPlayer { Id = 1, Firstname = "Robben", Lastname = "Robben", Age = 25, PositionId = 1, TeamId = 1, Image = "FootballPlayer/1.png" },
               new FootballPlayer { Id = 2, Firstname = "Pizarro", Lastname = "Pizarro", Age = 27, PositionId = 2, TeamId = 1, Image = "FootballPlayer/2.jpg" },
               new FootballPlayer { Id = 3, Firstname = "Martinez", Lastname = "Martinez", Age = 32, PositionId = 3, TeamId = 1, Image = "FootballPlayer/3.jpg" },
               new FootballPlayer { Id = 4, Firstname = "Schweinsteiger", Lastname = "Schweinsteiger", Age = 28, PositionId = 1, TeamId = 1, Image = "FootballPlayer/4.jpg" },
               new FootballPlayer { Id = 5, Firstname = "Rilbery", Lastname = "Rilbery", Age = 31, PositionId = 5, TeamId = 1, Image = "FootballPlayer/5.jpg" },
               new FootballPlayer { Id = 6, Firstname = "Alaba", Lastname = "Alaba", Age = 26, PositionId = 6, TeamId = 1, Image = "FootballPlayer/6.jpg" },
               new FootballPlayer { Id = 7, Firstname = "Lahm", Lastname = "Lahm", Age = 29, PositionId = 7, TeamId = 1, Image = "FootballPlayer/7.jpg" },
               new FootballPlayer { Id = 8, Firstname = "Dante", Lastname = "Dante", Age = 33, PositionId = 8, TeamId = 1, Image = "FootballPlayer/8.jpg" },
               new FootballPlayer { Id = 9, Firstname = "Benatia", Lastname = "Benatia", Age = 25, PositionId = 1, TeamId = 1, Image = "FootballPlayer/9.jpg" },
               new FootballPlayer { Id = 10, Firstname = "Neuer", Lastname = "Neuer", Age = 27, PositionId = 2, TeamId = 1, Image = "FootballPlayer/10.jpg" },
               new FootballPlayer { Id = 11, Firstname = "Bale", Lastname = "Bale", Age = 32, PositionId = 3, TeamId = 2, Image = "FootballPlayer/11.jpg" },
               new FootballPlayer { Id = 12, Firstname = "Benzema", Lastname = "Benzema", Age = 28, PositionId = 4, TeamId = 2, Image = "FootballPlayer/12.jpg" },
               new FootballPlayer { Id = 13, Firstname = "Kroos", Lastname = "Kroos", Age = 31, PositionId = 5, TeamId = 2, Image = "FootballPlayer/13.jpg" },
               new FootballPlayer { Id = 14, Firstname = "Silva", Lastname = "Silva", Age = 26, PositionId = 6, TeamId = 2, Image = "FootballPlayer/14.jpg" },
               new FootballPlayer { Id = 15, Firstname = "Carvajal", Lastname = "Carvajal", Age = 29, PositionId = 7, TeamId = 2, Image = "FootballPlayer/15.jpg" },
               new FootballPlayer { Id = 16, Firstname = "Modric", Lastname = "Modric", Age = 33, PositionId = 8, TeamId = 2, Image = "FootballPlayer/16.jpg" },
               new FootballPlayer { Id = 17, Firstname = "Nacho", Lastname = "Nacho", Age = 31, PositionId = 5, TeamId = 2, Image = "FootballPlayer/17.jpg" },
               new FootballPlayer { Id = 18, Firstname = "Pepe", Lastname = "Pepe", Age = 26, PositionId = 6, TeamId = 2, Image = "FootballPlayer/18.jpg" },
               new FootballPlayer { Id = 19, Firstname = "Ramos", Lastname = "Ramos", Age = 29, PositionId = 7, TeamId = 2, Image = "FootballPlayer/19.jpg" },
               new FootballPlayer { Id = 20, Firstname = "Casillas", Lastname = "Casillas", Age = 33, PositionId = 8, TeamId = 2, Image = "FootballPlayer/20.jpg" }
           );

            builder.Entity(typeof(Cart)).HasData(
               new Cart { Id = 1, Name = "Red", Image = "Cart/red.png" },
               new Cart { Id = 2, Name = "Yellow", Image = "Cart/yellow.png" }
           );

            builder.Entity(typeof(Stadium)).HasData(
              new Stadium { Id = 1, Name = "Infinity Ring", Address = "‎1 Scarlet Knight Way", Image = "Stadium/1.png" },
              new Stadium { Id = 2, Name = "Paragon Field", Address = "Jake Nevin Field House", Image = "Stadium/2.jfif" }
          );

            builder.Entity(typeof(PositionType)).HasData(
              new PositionType { Id = 1, Name = "3-4-3"},
              new PositionType { Id = 2, Name = "4-2-4"}
          );

            builder.Entity(typeof(FootballerPosition)).HasData(
              new FootballerPosition { Id = 1, Name = "1" },
              new FootballerPosition { Id = 2, Name = "2" },
              new FootballerPosition { Id = 3, Name = "3" },
              new FootballerPosition { Id = 4, Name = "4" },
              new FootballerPosition { Id = 5, Name = "5" },
              new FootballerPosition { Id = 6, Name = "6" },
              new FootballerPosition { Id = 7, Name = "7" },
              new FootballerPosition { Id = 8, Name = "8" },
              new FootballerPosition { Id = 9, Name = "9" },
              new FootballerPosition { Id = 10, Name = "10" }
          );

            builder.Entity(typeof(GameTime)).HasData(
               new GameTime { Id = 1, Team1Id = 1, Team2Id = 2, StadiumId = 1, Date = new DateTime(2019, 12, 26), PositionType1Id = 1, PositionType2Id = 2 }
           );

            builder.Entity(typeof(FootballCart)).HasData(
               new FootballCart { Id = 1, FootballPlayerId = 1, CartId = 1, GameTimeId = 1 },
               new FootballCart { Id = 2, FootballPlayerId = 2, CartId = 2, GameTimeId = 2 },
               new FootballCart { Id = 3, FootballPlayerId = 3, CartId = 1, GameTimeId = 1 },
               new FootballCart { Id = 4, FootballPlayerId = 4, CartId = 2, GameTimeId = 2 },
               new FootballCart { Id = 5, FootballPlayerId = 5, CartId = 1, GameTimeId = 1 },
               new FootballCart { Id = 6, FootballPlayerId = 6, CartId = 2, GameTimeId = 2 },
               new FootballCart { Id = 7, FootballPlayerId = 7, CartId = 1, GameTimeId = 1 },
               new FootballCart { Id = 8, FootballPlayerId = 8, CartId = 2, GameTimeId = 2 }
           );

            builder.Entity(typeof(FootballPlayerGameTime)).HasData(
               new FootballPlayerGameTime { Id = 1, FootballPlayerId = 1, GameTimeId = 1, FootballerPositionId = 1 },
               new FootballPlayerGameTime { Id = 2, FootballPlayerId = 2, GameTimeId = 1, FootballerPositionId = 2 },
               new FootballPlayerGameTime { Id = 3, FootballPlayerId = 3, GameTimeId = 1, FootballerPositionId = 3 },
               new FootballPlayerGameTime { Id = 4, FootballPlayerId = 4, GameTimeId = 1, FootballerPositionId = 4 },
               new FootballPlayerGameTime { Id = 5, FootballPlayerId = 5, GameTimeId = 1, FootballerPositionId = 5 },
               new FootballPlayerGameTime { Id = 6, FootballPlayerId = 6, GameTimeId = 1, FootballerPositionId = 6 },
               new FootballPlayerGameTime { Id = 7, FootballPlayerId = 7, GameTimeId = 1, FootballerPositionId = 7 },
               new FootballPlayerGameTime { Id = 8, FootballPlayerId = 8, GameTimeId = 1, FootballerPositionId = 8 },
               new FootballPlayerGameTime { Id = 9, FootballPlayerId = 9, GameTimeId = 1, FootballerPositionId = 9 },
               new FootballPlayerGameTime { Id = 10, FootballPlayerId = 10, GameTimeId = 1, FootballerPositionId = 10 },
               new FootballPlayerGameTime { Id = 11, FootballPlayerId = 11, GameTimeId = 1, FootballerPositionId = 1 },
               new FootballPlayerGameTime { Id = 12, FootballPlayerId = 12, GameTimeId = 1, FootballerPositionId = 2 },
               new FootballPlayerGameTime { Id = 13, FootballPlayerId = 13, GameTimeId = 1, FootballerPositionId = 3 },
               new FootballPlayerGameTime { Id = 14, FootballPlayerId = 14, GameTimeId = 1, FootballerPositionId = 4 },
               new FootballPlayerGameTime { Id = 15, FootballPlayerId = 15, GameTimeId = 1, FootballerPositionId = 5 },
               new FootballPlayerGameTime { Id = 16, FootballPlayerId = 16, GameTimeId = 1, FootballerPositionId = 6 },
               new FootballPlayerGameTime { Id = 17, FootballPlayerId = 17, GameTimeId = 1, FootballerPositionId = 7 },
               new FootballPlayerGameTime { Id = 18, FootballPlayerId = 18, GameTimeId = 1, FootballerPositionId = 8 },
               new FootballPlayerGameTime { Id = 19, FootballPlayerId = 19, GameTimeId = 1, FootballerPositionId = 9 },
               new FootballPlayerGameTime { Id = 20, FootballPlayerId = 20, GameTimeId = 1, FootballerPositionId = 10 }
           );
        }
    }

}
