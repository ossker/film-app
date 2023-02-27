using film_app.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace film_app.DAL
{
    public class FilmyContext:DbContext
    {
       
        public DbSet<Film> Filmy { get; set; }
        public DbSet<Kategoria> Kategorie { get; set; }

        public FilmyContext(DbContextOptions<FilmyContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Film>().HasData(
                new Film()
                {
                    Id = 1,
                    KategoriaId = 2,
                    Tytul = "Faraon",
                    Opis = "W tym dokumentalnym filmie poznajemy historię wielkich faraonów Egiptu i ich wpływ na kulturę i cywilizację. Od narodzin państwa egipskiego po upadek dynastii faraonów, wnikliwie przyglądamy się temu, jak władcy i ich rządy wpływały na rozwój kraju i jego ludzi. Przez wyjątkowe nagrania i eksplorację archeologiczną, odkrywamy tajemnice tych wspaniałych czasów i zobaczmy, jak dziedzictwo faraonów wpłynęło na naszą współczesną kulturę.",
                    Cena = 35,
                    Rezyser = "Tomasz Drozdowicz",
                    DataDodania = new DateTime(2021, 1, 22)
                },
                new Film()
                {
                    Id = 2,
                    KategoriaId = 1,
                    Tytul = "Świąteczny czas",
                    Opis = "W ten magiczny czas roku, rodzina Smithów zbiera się, aby świętować Boże Narodzenie. Jednak w miarę jak zbliża się święta, odkrywają, że w życiu chodzi o coś więcej niż tylko prezenty i dekoracje. To czas, aby nauczyć się, co naprawdę jest ważne i skupić się na wartościach rodzinnych.",
                    Cena = 20,
                    Rezyser = "Wojciech Smarzowski",
                    DataDodania = new DateTime(2020, 5, 13)
                },
                new Film()
                {
                    Id = 3,
                    KategoriaId = 3,
                    Tytul = "Złota rybka",
                    Opis = "W tej poruszającej opowieści, młody chłopiec odkrywa magiczną złotą rybkę, która spełnia mu trzy życzenia. Jednak gdy używa swoich życzeń, aby zaspokoić własne pragnienia, zdaje sobie sprawę, że prawdziwe szczęście można osiągnąć tylko poprzez życzliwość i bezinteresowność.",
                    Rezyser = "Michał Chaciński",
                    DataDodania = new DateTime(2022, 10, 3),
                },
                new Film()
                {
                    Id = 4,
                    KategoriaId = 3,
                    Tytul = "Kuba Puchaty 2",
                    Opis = "Kuba, sympatyczny i nieco psotny miś, powraca z nowymi przygodami w lesie. Tym razem musi uratować swoich przyjaciół przed złowrogiem myśliwym, który chce ich schwytać dla cyrku. Czy odwaga Kuby wystarczy, aby przechytrzyć myśliwego i ochronić swoją leśną rodzinę?",
                    Cena = 15,
                    Rezyser = "Tomasz Szwed",
                    DataDodania = new DateTime(2019, 9, 9),
                }

                );

            modelBuilder.Entity<Kategoria>().HasData(
                new Kategoria()
                {
                    Id = 1,
                    Nazwa = "Komedia",
                    Opis = "Komedia to gatunek filmowy, który ma na celu wywołanie u widza śmiechu i rozrywki. W komediach często występują zabawne sytuacje, postaci i dialogi, a cała historia skupia się na humorystycznych momentach."
                },
                new Kategoria()
                {
                    Id = 2,
                    Nazwa = "Dokumentalny",
                    Opis = "Dokumentalny to gatunek filmowy, który opowiada prawdziwe historie, często związane z faktami i wydarzeniami ze świata rzeczywistego. Dokumenty mają na celu przedstawienie widzom prawdziwych ludzi, miejsc, wydarzeń i idei w sposób obiektywny, wiarygodny i rzetelny."
                },
                new Kategoria()
                {
                    Id = 3,
                    Nazwa = "Animowany",
                    Opis = "Animowany to gatunek filmowy, który wykorzystuje technikę animacji do przedstawienia historii i postaci. Filmy animowane mogą zawierać różne style animacji, takie jak tradycyjna animacja rysunkowa, animacja komputerowa czy stop-motion, a ich główną cechą jest to, że są one stworzone przy użyciu grafiki komputerowej lub ręcznie rysowanych obrazów, zamiast z prawdziwych aktorów i scenografii."
                }

                );
        }
    }
}
