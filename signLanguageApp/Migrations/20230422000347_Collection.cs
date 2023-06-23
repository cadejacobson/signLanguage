using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace signLanguageApp.Migrations
{
    /// <inheritdoc />
    public partial class Collection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Collection",
                table: "Sign",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Collection",
                table: "Sign");
        }
    }
}
