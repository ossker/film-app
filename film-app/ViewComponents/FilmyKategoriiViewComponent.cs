using film_app.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace film_app.ViewComponents
{
    public class FilmyKategoriiViewComponent: ViewComponent
    {
        FilmyContext db;

        public FilmyKategoriiViewComponent(FilmyContext db)
        {
            this.db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync(string nazwaKategorii)
        {
            var kategoria = db.Kategorie.Include("Filmy").Where(k => k.Nazwa.ToUpper() == nazwaKategorii).Single();
            var filmyKategorii = kategoria.Filmy.ToList();
            return await Task.FromResult((IViewComponentResult)View("_FilmyKategorii", filmyKategorii));
        }
    }
}
