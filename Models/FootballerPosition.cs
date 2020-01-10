using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace December_24_2019_Football.Models
{
    public class FootballerPosition
    {
        public FootballerPosition()
        {
            FootballPlayerGameTimes = new HashSet<FootballPlayerGameTime>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<FootballPlayerGameTime> FootballPlayerGameTimes { get; set; }
    }
}
