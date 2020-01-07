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
              new Team { Id = 1, Name = "Amigos", CountryId = 1 },
              new Team { Id = 2, Name = "Mamacitas", CountryId = 1 },
              new Team { Id = 3, Name = "Liverpool FC", CountryId = 2 },
              new Team { Id = 4, Name = "Manchester City", CountryId = 2 }
          );

            builder.Entity(typeof(FootballPlayer)).HasData(
               new FootballPlayer { Id = 1, Firstname = "Messi", Lastname = "Lionel", Age = 25, PositionId = 1, TeamId = 1, Image = "FootballPlayer/1.png" },
               new FootballPlayer { Id = 2, Firstname = "Ronaldo", Lastname = "Cristiano", Age = 27, PositionId = 2, TeamId = 1, Image = "FootballPlayer/2.png" },
               new FootballPlayer { Id = 3, Firstname = "Xavi", Lastname = "Xavi", Age = 32, PositionId = 3, TeamId = 2, Image = "FootballPlayer/3.png" },
               new FootballPlayer { Id = 4, Firstname = "Iniesta", Lastname = "Andres", Age = 28, PositionId = 4, TeamId = 2, Image = "FootballPlayer/4.png" },
               new FootballPlayer { Id = 5, Firstname = "Ibrahimovic", Lastname = "Zlatan", Age = 31, PositionId = 5, TeamId = 3, Image = "FootballPlayer/5.png" },
               new FootballPlayer { Id = 6, Firstname = "Falcao", Lastname = "Radamel", Age = 26, PositionId = 6, TeamId = 3, Image = "FootballPlayer/6.png" },
               new FootballPlayer { Id = 7, Firstname = "Persie", Lastname = "Robin van", Age = 29, PositionId = 7, TeamId = 4, Image = "FootballPlayer/7.png" },
               new FootballPlayer { Id = 8, Firstname = "Pirlo", Lastname = "Andrea", Age = 33, PositionId = 8, TeamId = 4, Image = "FootballPlayer/8.png" }
           );

            builder.Entity(typeof(Cart)).HasData(
               new Cart { Id = 1, Name = "Red", Image = "Cart/red.png" },
               new Cart { Id = 2, Name = "Yellow", Image = "Cart/yellow.png" }
           );

            builder.Entity(typeof(Stadium)).HasData(
              new Stadium { Id = 1, Name = "Infinity Ring", Address = "‎1 Scarlet Knight Way", Image = "Stadium/1.png" },
              new Stadium { Id = 2, Name = "Paragon Field", Address = "Jake Nevin Field House", Image = "Stadium/2.jfif" }
          );

            builder.Entity(typeof(GameTime)).HasData(
               new GameTime { Id = 1, Team1Id = 1, Team2Id = 2, StadiumId = 1, Date = new DateTime(2019, 12, 26) },
               new GameTime { Id = 2, Team1Id = 3, Team2Id = 4, StadiumId = 2, Date = new DateTime(2019, 12, 27) }
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
               new FootballPlayerGameTime { Id = 1, FootballPlayerId = 1, GameTimeId = 1 },
               new FootballPlayerGameTime { Id = 2, FootballPlayerId = 2, GameTimeId = 2 }
           );
        }
    }

}
