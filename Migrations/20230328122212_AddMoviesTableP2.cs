using Microsoft.EntityFrameworkCore.Migrations;

namespace Movies.Migrations
{
    public partial class AddMoviesTableP2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                schema: "Movies",
                table: "Movies");

            migrationBuilder.RenameTable(
                name: "Movies",
                schema: "Movies",
                newName: "movies",
                newSchema: "Movies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_movies",
                schema: "Movies",
                table: "movies",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_movies",
                schema: "Movies",
                table: "movies");

            migrationBuilder.RenameTable(
                name: "movies",
                schema: "Movies",
                newName: "Movies",
                newSchema: "Movies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                schema: "Movies",
                table: "Movies",
                column: "Id");
        }
    }
}
