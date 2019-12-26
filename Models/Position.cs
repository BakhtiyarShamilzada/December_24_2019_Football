using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace December_24_2019_Football.Models
{
    public class Position
    {
        public Position()
        {
            FootballPlayers = new HashSet<FootballPlayer>();
        }
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<FootballPlayer> FootballPlayers { get; set; }
    }
}
