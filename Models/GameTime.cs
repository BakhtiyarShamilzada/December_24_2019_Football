﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace December_24_2019_Football.Models
{
    public class GameTime
    {
        public GameTime()
        {
            FootballPlayerGameTimes = new HashSet<FootballPlayerGameTime>();
            FootballCarts = new HashSet<FootballCart>();
        }
        public int Id { get; set; }

        public int Team1Id { get; set; }

        public int Team2Id { get; set; }

        public int PositionType1Id { get; set; }

        public int PositionType2Id { get; set; }

        public int StadiumId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime Date { get; set; }

        public string Color1 { get; set; }

        public string Color2 { get; set; }

        public virtual Stadium Stadium { get; set; }

        public virtual ICollection<FootballCart> FootballCarts { get; set; }
        public virtual ICollection<FootballPlayerGameTime> FootballPlayerGameTimes { get; set; }
    }
}
