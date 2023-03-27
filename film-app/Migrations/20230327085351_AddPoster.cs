using Microsoft.EntityFrameworkCore.Migrations;

namespace film_app.Migrations
{
    public partial class AddPoster : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Plakat",
                table: "Filmy",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Plakat",
                table: "Filmy");
        }
    }
}
