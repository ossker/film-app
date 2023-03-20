using System.Collections.Generic;

namespace film_app.Models
{
    public class KategoriaViewModel
    {

        public Kategoria kategoria { get; set; }

        public IEnumerable<Film> FilmyKategorii { get; set; }
        public IEnumerable<Film> FilmyNajnowsze { get; set; }



    }
}
