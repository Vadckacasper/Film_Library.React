using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Film_Library.React.Models
{
    public class Actor
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Path_Img { get; set; }

        public IEnumerable<Film> films;
    }
}
