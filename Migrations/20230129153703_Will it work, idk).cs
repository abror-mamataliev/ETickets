using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETickets.Migrations
{
    /// <inheritdoc />
    public partial class Willitworkidk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActorsMovies_Actors_MovieId",
                table: "ActorsMovies");

            migrationBuilder.AddForeignKey(
                name: "FK_ActorsMovies_Actors_ActorId",
                table: "ActorsMovies",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActorsMovies_Actors_ActorId",
                table: "ActorsMovies");

            migrationBuilder.AddForeignKey(
                name: "FK_ActorsMovies_Actors_MovieId",
                table: "ActorsMovies",
                column: "MovieId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
