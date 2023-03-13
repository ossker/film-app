using film_app.DAL;
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
            var filmy = kategoria.Filmy.ToList();
            ViewBag.nazwa = nazwaKategorii;
            return View(filmy);
        }
     }
}
