using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Film_Library.React.Models
{
    /// <summary>
    /// The class that provides the actor model.
    /// </summary>
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DateBirth { get; set; }
        public string PlaceBirth { get; set; }
        public string Path_Img { get; set; }

        public IEnumerable<FilmActor> Films { get; set; }


    }
}
