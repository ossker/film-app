using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace film_app.Models
{
    public class Film
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Wpisz tytuł")]
        [StringLength(50)]
        public string Tytul { get; set; }

        [Required(ErrorMessage = "Wpisz reżysera")]
        [StringLength(50)]
        public string Rezyser { get; set; }

        [Required(ErrorMessage = "Wpisz opis")]
        [StringLength(1000)]
        public string Opis { get; set; }
        public decimal? Cena { get; set; }
        public DateTime DataDodania { get; set; }

        public int KategoriaId { get; set; }
        public Kategoria Kategoria { get; set; }

    }
}