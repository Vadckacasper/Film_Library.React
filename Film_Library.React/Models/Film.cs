using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Film_Library.React.Models
{
    public class Film
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public string Countries { get; set; }
        public string Producer { get; set; }
        public string YearProduction { get; set; }
        public string PathImg { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public IEnumerable<Actor> Actors { get; set; }

        public Film()
        {
            Genres = new List<Genre>();
            Actors = new List<Actor>();
        }

    }
}
