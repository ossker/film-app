using film_app.DAL;
using film_app.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace film_app.Controllers
{
    public class FilmyController : Controller
    {
        FilmyContext db;

        public FilmyController(FilmyContext db)
        {
            this.db = db;
        }

        public IActionResult Lista(string nazwaKategorii)
        {
            var kategoria = db.Kategorie.Include("Filmy").Where(k=>k.Nazwa.ToUpper() == nazwaKategorii).Single();
            var filmyKategorii = kategoria.Filmy.ToList();
            ViewBag.nazwa = nazwaKategorii;

            var filmy = new KategoriaViewModel
            {
                kategoria = kategoria,
                FilmyKategorii = filmyKategorii,
                FilmyNajnowsze = filmyKategorii.OrderByDescending(f => f.DataDodania).Take(3)
            };

            return View(filmy);
        }

        public IActionResult Szczegoly(int id)
        {
            var film = db.Filmy.Where(k => k.Id == id).Single();
            ViewBag.nazwa = film.Tytul;
            return View(film);
        }
     }
}
