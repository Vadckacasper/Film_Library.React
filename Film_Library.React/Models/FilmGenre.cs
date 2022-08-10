using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Film_Library.React.Models
{
    public class FilmGenre
    {
        [Key]
        public int Id { get; set; }
        public int Id_Film { get; set; }
        public int Id_Genre { get; set; }
        public Film Film { get; set; }
        public Genre Genre { get; set; }
    }
}
