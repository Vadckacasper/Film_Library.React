using Film_Library.React.Models;
using Film_Library.React.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Film_Library.React.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorsController : ControllerBase
    {
        private FilmLibraryContext db;

        public ActorsController(FilmLibraryContext context)
        {
            db = context;
        }

        [HttpGet("_actors/{id}")]
        public async Task<ActionResult<IEnumerable<CardActorViewModel>>> GetByFilmIdAsync(int id)
        {
            IEnumerable<int> idActors = await db.FilmActors.Where(item => item.Id_Film == id).Select(it => it.Id_Actor).ToListAsync();

            List<CardActorViewModel> Actors = new List<CardActorViewModel>();
            foreach (int idActor in idActors)
            {
                Actors.Add(db.Actors.
                    Select(x => new CardActorViewModel
                    {
                        Id = x.Id,
                        FullName = x.Name + " " + x.Surname,
                        DateBirth = x.DateBirth,
                        PlaceBirth = x.PlaceBirth,
                        Path_Img = x.Path_Img
                    }).FirstOrDefault(x => x.Id == idActor));
            }
            return Actors;
        }

    }
}
