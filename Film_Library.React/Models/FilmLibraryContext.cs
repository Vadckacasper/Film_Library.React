using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Film_Library.React.Models
{
    /// <summary>
    /// Class, defines the data context used to interact with the database.
    /// </summary>
    public class FilmLibraryContext : DbContext
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<FilmActor> FilmActors { get; set; }
        public DbSet<FilmGenre> FilmGenres { get; set; }
        public FilmLibraryContext() { }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="options">Data context settings.</param>
        public FilmLibraryContext(DbContextOptions<FilmLibraryContext> options):base(options)
        {
            Database.EnsureCreated();
        }
    }
}
