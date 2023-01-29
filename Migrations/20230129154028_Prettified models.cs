using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETickets.Migrations
{
    /// <inheritdoc />
    public partial class Prettifiedmodels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "ActorsMovies");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ActorsMovies",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
