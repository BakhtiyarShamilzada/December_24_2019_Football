using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace December_24_2019_Football.Models
{
    public class Transfer
    {
        public int Id { get; set; }

        public int FootballPlayerId { get; set; }

        public int OldTeamId { get; set; }

        public int NewTeamId { get; set; }

        public decimal Price { get; set; }

        public virtual FootballPlayer FootballPlayer { get; set; }
    }
}
