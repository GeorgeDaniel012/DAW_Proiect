using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace daw_proiect.Migrations
{
    /// <inheritdoc />
    public partial class fifth_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Produs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Produs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
