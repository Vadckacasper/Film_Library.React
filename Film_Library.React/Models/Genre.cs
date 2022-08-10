using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Film_Library.React.Models
{
    /// <summary>
    ///  The class that provides the genre model.
    /// </summary>
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<FilmGenre> Films { get; set; }
    }
}
