using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace December_24_2019_Football.Models
{
    public class FootballPlayer
    {
        public FootballPlayer()
        {
            FootballCarts = new HashSet<FootballCart>();
            FootballPlayerGameTimes = new HashSet<FootballPlayerGameTime>();
        }
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Firstname { get; set; }

        [StringLength(50, ErrorMessage = "Ad maksimum 50 simvol ola bilər")]
        public string Lastname { get; set; }

        public int Age { get; set; }

        public int PositionId { get; set; }

        public int TeamId { get; set; }

        public string Image { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }

        public virtual Position Position { get; set; }

        public virtual Team Team { get; set; }

        public virtual ICollection<FootballCart> FootballCarts { get; set; }

        public virtual ICollection<FootballPlayerGameTime> FootballPlayerGameTimes { get; set; }
    }
}
