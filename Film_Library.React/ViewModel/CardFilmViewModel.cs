using Film_Library.React.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Film_Library.React.ViewModel
{
    public class CardFilmViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }

        public IEnumerable<Actor> Actors { get; set; }
        public string PathImg { get; set; }

        public CardFilmViewModel()
        {
            Actors = new List<Actor>();
        }
    }
}
