using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace December_24_2019_Football.Models
{
    public class FootballCart
    {
        public int Id { get; set; }

        public int FootballPlayerId { get; set; }

        public int CartId { get; set; }

        public int GameTimeId { get; set; }

        public virtual FootballPlayer FootballPlayer { get; set; }

        public virtual GameTime GameTime { get; set; }

        public virtual Cart Cart { get; set; }
    }
}
