using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace film_app.Models
{
    public class Kategoria
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public ICollection<Film> Filmy { get; set; }
    }
}