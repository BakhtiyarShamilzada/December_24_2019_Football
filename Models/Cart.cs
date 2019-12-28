using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace December_24_2019_Football.Models
{
    public class Cart
    {
        public Cart()
        {
            FootballCarts = new HashSet<FootballCart>();
        }
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        public string Image { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }

        public virtual ICollection<FootballCart> FootballCarts { get; set; }
    }
}
