using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace film_app.Models
{
    public class DodawanieFilmowViewModel
    {
        public Film film { get; set; }

        public IFormFile Plakat { get; set; }
        public List<Kategoria> kategoria { get; set; }
    }
}
