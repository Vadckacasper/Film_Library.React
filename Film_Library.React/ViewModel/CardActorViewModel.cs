using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Film_Library.React.ViewModel
{
    /// <summary>
    /// The data model returned for the actor card
    /// </summary>
    public class CardActorViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string DateBirth { get; set; }
        public string PlaceBirth { get; set; }
        public string Path_Img { get; set; }

    }
}
