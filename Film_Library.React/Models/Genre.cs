using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Film_Library.React.Models
{
    public class Genre
    {
        public string Name { get; set; }
        public IEnumerable<Film> films;
    }
}
