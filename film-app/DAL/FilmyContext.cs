using film_app.Models;
using Microsoft.EntityFrameworkCore;

namespace film_app.DAL
{
    public class FilmyContext:DbContext
    {
       
        public DbSet<Film> Filmy { get; set; }
        public DbSet<Kategoria> Kategorie { get; set; }

        public FilmyContext(DbContextOptions<FilmyContext> options) : base(options)
        {

        }

    }
}
