using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Film_Library.React.Models
{
    /// <summary>
    /// A class that provides a model of the relationship table between a movie and an actor.
    /// </summary>
    public class FilmActor
    {
        [Key]
        public int Id { get; set; }
        public int Id_Film { get; set; }
        public int Id_Actor { get; set; }
        public Film Film { get; set; }
        public Actor Actor { get; set; }
    }
}
