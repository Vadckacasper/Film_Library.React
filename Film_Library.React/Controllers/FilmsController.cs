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
    [ApiController]
    [Route("api/[controller]")]
    public class FilmsController : ControllerBase
    {
        private FilmLibraryContext db;

        public FilmsController(FilmLibraryContext context)
        {
            db = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CardFilmViewModel>>> GetAllAsync()
        {
            return await db.Films.Include(film => film.Actors).Select(
                x => new CardFilmViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    ShortDescription = x.ShortDescription,
                    PathImg = x.PathImg,
                    FullNameActors = x.Actors.Select(actor => actor.Name + " " + actor.Surname).ToList()
                }).ToListAsync();
        }

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
        [HttpGet("_search/{name}")]
        public async Task<ActionResult<IEnumerable<CardFilmViewModel>>> GetByNameAsync(string name)
        {
            if (name == "")
            {
                return await GetAllAsync();
            }
            return await  db.Films.Include(film => film.Actors).Where(x => x.Name.Contains(name)).Select(
                x => new CardFilmViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    ShortDescription = x.ShortDescription,
                    PathImg = x.PathImg,
                    FullNameActors = x.Actors.Select(actor => actor.Name + " " + actor.Surname).ToList()
                }).ToListAsync();

           }

        [HttpPost]
        public async Task<ActionResult<Film>> Post(Film film)
        {
            if (film == null)
            {
                return BadRequest();
            }
            db.Films.Add(film);
            await db.SaveChangesAsync();
            return Ok(film);
        }
    }
}
