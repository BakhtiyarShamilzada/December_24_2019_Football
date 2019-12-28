using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace December_24_2019_Football.Models
{
    public class Stadium
    {
        public Stadium()
        {
            GameTimes = new HashSet<GameTime>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Image { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }

        public virtual ICollection<GameTime> GameTimes { get; set; }
    }
}
