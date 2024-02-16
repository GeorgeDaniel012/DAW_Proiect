using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace daw_proiect.Migrations
{
    /// <inheritdoc />
    public partial class sixth_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipComanda",
                table: "Comanda");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipComanda",
                table: "Comanda",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
