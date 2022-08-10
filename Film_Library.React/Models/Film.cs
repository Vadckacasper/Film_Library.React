using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Film_Library.React.Models
{
    /// <summary>
    /// The class that provides the movie model.
    /// </summary>
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
        public IEnumerable<FilmGenre> Genre { get; set; }
        public IEnumerable<FilmActor> Actor { get; set; }


    }
}
