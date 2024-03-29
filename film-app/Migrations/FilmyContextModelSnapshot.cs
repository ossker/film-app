﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using film_app.DAL;

namespace film_app.Migrations
{
    [DbContext(typeof(FilmyContext))]
    partial class FilmyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("film_app.Models.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("Cena")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DataDodania")
                        .HasColumnType("datetime2");

                    b.Property<int>("KategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Plakat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rezyser")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tytul")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("czasTrwania")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategoriaId");

                    b.ToTable("Filmy");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cena = 35m,
                            DataDodania = new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KategoriaId = 2,
                            Opis = "W tym dokumentalnym filmie poznajemy historię wielkich faraonów Egiptu i ich wpływ na kulturę i cywilizację. Od narodzin państwa egipskiego po upadek dynastii faraonów, wnikliwie przyglądamy się temu, jak władcy i ich rządy wpływały na rozwój kraju i jego ludzi. Przez wyjątkowe nagrania i eksplorację archeologiczną, odkrywamy tajemnice tych wspaniałych czasów i zobaczmy, jak dziedzictwo faraonów wpłynęło na naszą współczesną kulturę.",
                            Rezyser = "Tomasz Drozdowicz",
                            Tytul = "Faraon"
                        },
                        new
                        {
                            Id = 2,
                            Cena = 20m,
                            DataDodania = new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KategoriaId = 1,
                            Opis = "W ten magiczny czas roku, rodzina Smithów zbiera się, aby świętować Boże Narodzenie. Jednak w miarę jak zbliża się święta, odkrywają, że w życiu chodzi o coś więcej niż tylko prezenty i dekoracje. To czas, aby nauczyć się, co naprawdę jest ważne i skupić się na wartościach rodzinnych.",
                            Rezyser = "Wojciech Smarzowski",
                            Tytul = "Świąteczny czas"
                        },
                        new
                        {
                            Id = 3,
                            DataDodania = new DateTime(2022, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KategoriaId = 3,
                            Opis = "W tej poruszającej opowieści, młody chłopiec odkrywa magiczną złotą rybkę, która spełnia mu trzy życzenia. Jednak gdy używa swoich życzeń, aby zaspokoić własne pragnienia, zdaje sobie sprawę, że prawdziwe szczęście można osiągnąć tylko poprzez życzliwość i bezinteresowność.",
                            Rezyser = "Michał Chaciński",
                            Tytul = "Złota rybka"
                        },
                        new
                        {
                            Id = 4,
                            Cena = 15m,
                            DataDodania = new DateTime(2019, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KategoriaId = 3,
                            Opis = "Kuba, sympatyczny i nieco psotny miś, powraca z nowymi przygodami w lesie. Tym razem musi uratować swoich przyjaciół przed złowrogiem myśliwym, który chce ich schwytać dla cyrku. Czy odwaga Kuby wystarczy, aby przechytrzyć myśliwego i ochronić swoją leśną rodzinę?",
                            Rezyser = "Tomasz Szwed",
                            Tytul = "Kuba Puchaty 2"
                        });
                });

            modelBuilder.Entity("film_app.Models.Kategoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nazwa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kategorie");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nazwa = "Komedia",
                            Opis = "Komedia to gatunek filmowy, który ma na celu wywołanie u widza śmiechu i rozrywki. W komediach często występują zabawne sytuacje, postaci i dialogi, a cała historia skupia się na humorystycznych momentach."
                        },
                        new
                        {
                            Id = 2,
                            Nazwa = "Dokumentalny",
                            Opis = "Dokumentalny to gatunek filmowy, który opowiada prawdziwe historie, często związane z faktami i wydarzeniami ze świata rzeczywistego. Dokumenty mają na celu przedstawienie widzom prawdziwych ludzi, miejsc, wydarzeń i idei w sposób obiektywny, wiarygodny i rzetelny."
                        },
                        new
                        {
                            Id = 3,
                            Nazwa = "Animowany",
                            Opis = "Animowany to gatunek filmowy, który wykorzystuje technikę animacji do przedstawienia historii i postaci. Filmy animowane mogą zawierać różne style animacji, takie jak tradycyjna animacja rysunkowa, animacja komputerowa czy stop-motion, a ich główną cechą jest to, że są one stworzone przy użyciu grafiki komputerowej lub ręcznie rysowanych obrazów, zamiast z prawdziwych aktorów i scenografii."
                        });
                });

            modelBuilder.Entity("film_app.Models.Film", b =>
                {
                    b.HasOne("film_app.Models.Kategoria", "Kategoria")
                        .WithMany("Filmy")
                        .HasForeignKey("KategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategoria");
                });

            modelBuilder.Entity("film_app.Models.Kategoria", b =>
                {
                    b.Navigation("Filmy");
                });
#pragma warning restore 612, 618
        }
    }
}
