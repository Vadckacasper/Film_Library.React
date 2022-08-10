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
    /// <summary>
    /// Controller class for working with the actor model
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ActorsController : ControllerBase
    {
        private FilmLibraryContext db;

        /// <summary>
        /// Constructor of the class for connecting to the database.
        /// </summary>
        /// <param name="context">Data context</param>
        public ActorsController(FilmLibraryContext context)
        {
            db = context;
        }

        /// <summary>
        ///Asynchronous method for getting a list of actors by movie ID.
        /// </summary>
        /// <param name="id">Movie id.</param>
        /// <returns>List of actors.</returns>
        [HttpGet("_actors/{id}")]
        public async Task<ActionResult<IEnumerable<CardActorViewModel>>> GetByFilmIdAsync(int id)
        {
            IEnumerable<int> idActors = await db.FilmActors.Where(item => item.Id_Film == id).Select(it => it.Id_Actor).ToListAsync();

            return await db.Actors.
                    Select(x => new CardActorViewModel
                    {
                        Id = x.Id,
                        FullName = x.Name + " " + x.Surname,
                        DateBirth = x.DateBirth,
                        PlaceBirth = x.PlaceBirth,
                        Path_Img = x.Path_Img
                    }).Where(x => idActors.Contains(x.Id)).ToListAsync();
        }

    }
}
