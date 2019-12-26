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

        public IEnumerable<Position> Positions { get; set; }

        public int FootballPlayerId { get; set; }

        public int CartId { get; set; }
        public int PositionId { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date1 { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date2 { get; set; }

    }
}
