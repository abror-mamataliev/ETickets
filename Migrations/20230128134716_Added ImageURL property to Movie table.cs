using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETickets.Migrations
{
    /// <inheritdoc />
    public partial class AddedImageURLpropertytoMovietable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Movies",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Movies");
        }
    }
}
