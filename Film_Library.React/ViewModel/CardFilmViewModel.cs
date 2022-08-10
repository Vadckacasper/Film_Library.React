using Film_Library.React.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Film_Library.React.ViewModel
{
    /// <summary>
    /// The data model returned for the movie card
    /// </summary>
    public class CardFilmViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }

        public List<string> FullNameActors { get; set; } = new List<string>();
        public string PathImg { get; set; }

    }
}
