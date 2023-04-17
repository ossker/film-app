using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace film_app.Models
{
    public class DodawanieFilmowViewModel
    {
        public Film film { get; set; }

        [Required(ErrorMessage="Dodaj Plakat!")]
        public IFormFile Plakat { get; set; }
        public List<Kategoria> kategoria { get; set; }
    }
}
