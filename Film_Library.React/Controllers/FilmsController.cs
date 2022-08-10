using Film_Library.React.Models;
using Film_Library.React.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Film_Library.React.Controllers
{
    /// <summary>
    /// Controller class for working with the movie model
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class FilmsController : ControllerBase
    {
        private FilmLibraryContext db;

        /// <summary>
        /// Constructor of the class for connecting to the database.
        /// </summary>
        /// <param name="context">Data context</param>
        public FilmsController(FilmLibraryContext context)
        {
            db = context;
        }

        /// <summary>
        /// Asynchronous method for getting all movies
        /// </summary>
        /// <returns>List of films type CardFilmViewModel</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CardFilmViewModel>>> GetAllAsync()
        {
            return await db.Films.Select(
                film => new CardFilmViewModel
                {
                    Id = film.Id,
                    Name = film.Name,
                    ShortDescription = film.ShortDescription,
                    PathImg = film.PathImg,
                    FullNameActors = db.FilmActors.Include(actor => actor.Actor).
                                                    Where(x => x.Id_Film == film.Id).
                                                    Select(actor => actor.Actor.Name + " " + actor.Actor.Surname).Take(3).ToList()
                }).ToListAsync();
        }
        /// <summary>
        /// Asynchronous method of getting a movie by ID
        /// </summary>
        /// <param name="Id">Movie id</param>
        /// <returns>Type object Film</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Film>> GetByIdAsync(int Id)
        {
            Film film = await db.Films.FirstOrDefaultAsync(x => x.Id == Id);
            if (film == null)
            {
                return NotFound();
            }
            return new ObjectResult(film);
        }

        /// <summary>
        /// Asynchronous method of searching for films by name, actors' name, genre.
        /// </summary>
        /// <param name="name">Movie title, actor's name, genre</param>
        /// <returns>List of films of the type CardFilmViewModel</returns>
        [HttpGet("_search/{name}")]
        public async Task<ActionResult<IEnumerable<CardFilmViewModel>>> GetByNameAsync(string name)
        {
            if (name == "")
            {
                return await GetAllAsync();
            }
            //I get a list of it films related to the actor
            IEnumerable<int> Actors = await db.Actors.Where(x => x.Name.StartsWith(name) || x.Surname.StartsWith(name) || (x.Name+" "+x.Surname).StartsWith(name)).
                                                      Join(db.FilmActors,
                                                            u => u.Id,
                                                            c => c.Id_Actor,
                                                            (u, c) => c.Id_Film).ToListAsync();
            //I get a list of IT films of the genre
            IEnumerable<int> Genres = await db.Genres.Where(x => x.Name.StartsWith(name)).
                                                      Join(db.FilmGenres,
                                                            u => u.Id,
                                                            c => c.Id_Genre,
                                                            (u, c) => c.Id_Film).ToListAsync();

            return await db.Films.Include(actor => actor.Actor).
                                  Include(genre => genre.Genre).
                                  Where(x => x.Name.StartsWith(name) || Actors.Contains(x.Id) || Genres.Contains(x.Id)).
                                  Select(film => new CardFilmViewModel
                                  {
                                       Id = film.Id,
                                       Name = film.Name,
                                       ShortDescription = film.ShortDescription,
                                       PathImg = film.PathImg,
                                       FullNameActors = db.FilmActors.Include(actor => actor.Actor).
                                                                      Where(x => x.Id_Film == film.Id).
                                                                      Select(actor => actor.Actor.Name + " " + actor.Actor.Surname).Take(3).ToList()
                                  }).ToListAsync();
        }
    }
}
