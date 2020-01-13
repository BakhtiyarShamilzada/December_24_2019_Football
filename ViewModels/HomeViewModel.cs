using December_24_2019_Football.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace December_24_2019_Football.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Cart> Carts { get; set; }

        public IEnumerable<FootballCart> FootballCarts { get; set; }

        public IEnumerable<FootballPlayer> FootballPlayers { get; set; }
        public FootballPlayer FootballPlayer { get; set; }

        public IEnumerable<Position> Positions { get; set; }

        public IEnumerable<Team> Teams { get; set; }

        public IEnumerable<Stadium> Stadiums { get; set; }

        public IEnumerable<GameTime> GameTimes { get; set; }

        public IEnumerable<FootballPlayerGameTime> FootballPlayerGameTimes { get; set; }

        public IEnumerable<PositionType> PositionTypes { get; set; }

        public int GameTimeId { get; set; }

        public int Team1Id { get; set; }

        public int PositionType1Id { get; set; }

        public int PositionType2Id { get; set; }

        public int Team2Id { get; set; }

        public int StadiumId { get; set; }

        public int FootballPlayerId { get; set; }

        public int CartId { get; set; }

        public int PositionId { get; set; }

        public string FootballPlayersId { get; set; }

        public string FootballersIdPositionsId { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date1 { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date2 { get; set; }

    }
}
