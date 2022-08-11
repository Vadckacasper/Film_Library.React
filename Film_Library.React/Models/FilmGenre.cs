using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Film_Library.React.Models
{
    /// <summary>
    /// A class that provides a model of the relationship table between a movie and an genre.
    /// </summary>
    public class FilmGenre
    {
        [Key]
        public int Id { get; set; }
        public int Id_Film { get; set; }
        public int Id_Genre { get; set; }
        [ForeignKey("Id_Film")]
        public Film Film { get; set; }
        [ForeignKey("Id_Genre")]
        public Genre Genre { get; set; }
    }
}
