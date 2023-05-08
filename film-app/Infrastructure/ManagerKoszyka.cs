using film_app.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;

namespace film_app.Infrastructure
{
    public static class ManagerKoszyka
    {
        public static int UsunZKoszyka(ISession session, int id)
        {
            var cart = WezRzeczy(session);
            var film = cart.Find(i => i.Film.Id == id);
            int ilosc = 0;
            if (film == null)
            {
                return ilosc;
            }
            if (film.Ilosc > 1)
            {
                film.Ilosc--;
                ilosc = film.Ilosc;
            }
            else
            {
                cart.Remove(film);
            }
            session.SetObjectAsJson(Consts.KoszykSessionKey, cart);
            return ilosc;
        }

        private static List<KoszykRzecz> WezRzeczy(ISession session)
        {
            var cart = SessionHelper.GetObjectFromJson<List<KoszykRzecz>>(session, Consts.KoszykSessionKey);
            if (cart == null)
            {
                cart = new List<KoszykRzecz>();
            }
            return cart;
        }


        public static decimal? UstawWartosc(ISession session)
        {
            var rzeczy = WezRzeczy(session);
            return rzeczy.Sum(rz => rz.Ilosc * rz.Wartosc);
        }
    }
}
