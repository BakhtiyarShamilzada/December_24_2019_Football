using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace December_24_2019_Football.Models
{
    public class Team
    {
        public Team()
        {
            GameTimes = new HashSet<GameTime>();
            FootballPlayers = new HashSet<FootballPlayer>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<GameTime> GameTimes { get; set; }
        public virtual ICollection<FootballPlayer> FootballPlayers { get; set; }
    }
}
