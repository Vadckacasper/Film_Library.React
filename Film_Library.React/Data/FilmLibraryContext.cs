﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Film_Library.React.Models
{
    public class FilmLibraryContext : DbContext
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public FilmLibraryContext() { }
        public FilmLibraryContext(DbContextOptions<FilmLibraryContext> options):base(options)
        {
            Database.EnsureCreated();
        }
    }
}
