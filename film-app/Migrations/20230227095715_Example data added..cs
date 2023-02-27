using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace film_app.Migrations
{
    public partial class Exampledataadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategorie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Filmy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tytul = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Rezyser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Cena = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DataDodania = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Filmy_Kategorie_KategoriaId",
                        column: x => x.KategoriaId,
                        principalTable: "Kategorie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kategorie",
                columns: new[] { "Id", "Nazwa", "Opis" },
                values: new object[] { 1, "Komedia", "Komedia to gatunek filmowy, który ma na celu wywołanie u widza śmiechu i rozrywki. W komediach często występują zabawne sytuacje, postaci i dialogi, a cała historia skupia się na humorystycznych momentach." });

            migrationBuilder.InsertData(
                table: "Kategorie",
                columns: new[] { "Id", "Nazwa", "Opis" },
                values: new object[] { 2, "Dokumentalny", "Dokumentalny to gatunek filmowy, który opowiada prawdziwe historie, często związane z faktami i wydarzeniami ze świata rzeczywistego. Dokumenty mają na celu przedstawienie widzom prawdziwych ludzi, miejsc, wydarzeń i idei w sposób obiektywny, wiarygodny i rzetelny." });

            migrationBuilder.InsertData(
                table: "Kategorie",
                columns: new[] { "Id", "Nazwa", "Opis" },
                values: new object[] { 3, "Animowany", "Animowany to gatunek filmowy, który wykorzystuje technikę animacji do przedstawienia historii i postaci. Filmy animowane mogą zawierać różne style animacji, takie jak tradycyjna animacja rysunkowa, animacja komputerowa czy stop-motion, a ich główną cechą jest to, że są one stworzone przy użyciu grafiki komputerowej lub ręcznie rysowanych obrazów, zamiast z prawdziwych aktorów i scenografii." });

            migrationBuilder.InsertData(
                table: "Filmy",
                columns: new[] { "Id", "Cena", "DataDodania", "KategoriaId", "Opis", "Rezyser", "Tytul" },
                values: new object[,]
                {
                    { 2, 20m, new DateTime(2020, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "W ten magiczny czas roku, rodzina Smithów zbiera się, aby świętować Boże Narodzenie. Jednak w miarę jak zbliża się święta, odkrywają, że w życiu chodzi o coś więcej niż tylko prezenty i dekoracje. To czas, aby nauczyć się, co naprawdę jest ważne i skupić się na wartościach rodzinnych.", "Wojciech Smarzowski", "Świąteczny czas" },
                    { 1, 35m, new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "W tym dokumentalnym filmie poznajemy historię wielkich faraonów Egiptu i ich wpływ na kulturę i cywilizację. Od narodzin państwa egipskiego po upadek dynastii faraonów, wnikliwie przyglądamy się temu, jak władcy i ich rządy wpływały na rozwój kraju i jego ludzi. Przez wyjątkowe nagrania i eksplorację archeologiczną, odkrywamy tajemnice tych wspaniałych czasów i zobaczmy, jak dziedzictwo faraonów wpłynęło na naszą współczesną kulturę.", "Tomasz Drozdowicz", "Faraon" },
                    { 3, null, new DateTime(2022, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "W tej poruszającej opowieści, młody chłopiec odkrywa magiczną złotą rybkę, która spełnia mu trzy życzenia. Jednak gdy używa swoich życzeń, aby zaspokoić własne pragnienia, zdaje sobie sprawę, że prawdziwe szczęście można osiągnąć tylko poprzez życzliwość i bezinteresowność.", "Michał Chaciński", "Złota rybka" },
                    { 4, 15m, new DateTime(2019, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Kuba, sympatyczny i nieco psotny miś, powraca z nowymi przygodami w lesie. Tym razem musi uratować swoich przyjaciół przed złowrogiem myśliwym, który chce ich schwytać dla cyrku. Czy odwaga Kuby wystarczy, aby przechytrzyć myśliwego i ochronić swoją leśną rodzinę?", "Tomasz Szwed", "Kuba Puchaty 2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Filmy_KategoriaId",
                table: "Filmy",
                column: "KategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filmy");

            migrationBuilder.DropTable(
                name: "Kategorie");
        }
    }
}
