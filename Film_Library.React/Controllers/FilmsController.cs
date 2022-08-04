using Film_Library.React.Models;
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
        public IEnumerable<Film> Get()
        {
            // return  db.Films.ToList();
            return new Film[] {new Film { Id = 1, Name="Гарри Поттер 1"},
                              new Film {Id = 2, Name = "Гарри Поттер философский камень", ShortDescription= "Описание маленькое", FullDescription = "БОЛЬШОЕ ОПИСАНИЕ"} };
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Film>> Get(int Id)
        {
            Film film =  await db.Films.FirstOrDefaultAsync(x => x.Id == Id);
            if(film == null)
            {
                return NotFound();
            }
            return new ObjectResult(film);
        }

        [HttpPost]
        public async Task<ActionResult<Film>> Post(Film film)
        {
            if(film == null)
            {
                return BadRequest();
            }
            db.Films.Add(film);
            await db.SaveChangesAsync();
            return Ok(film);
        }
    }
}
