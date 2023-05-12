using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataStorage.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "Feature");

            migrationBuilder.AddColumn<string>(
                name: "fearture_number",
                table: "Feature",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fearture_number",
                table: "Feature");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Feature",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
