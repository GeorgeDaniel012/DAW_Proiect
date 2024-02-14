using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace daw_proiect.Migrations
{
    /// <inheritdoc />
    public partial class secondmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdresaPrincipala_User_UserId",
                table: "AdresaPrincipala");

            migrationBuilder.DropForeignKey(
                name: "FK_Comanda_User_UserId",
                table: "Comanda");

            migrationBuilder.DropForeignKey(
                name: "FK_Recenzie_User_UserId",
                table: "Recenzie");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Recenzie",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Recenzie_UserId",
                table: "Recenzie",
                newName: "IX_Recenzie_ClientId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Comanda",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Comanda_UserId",
                table: "Comanda",
                newName: "IX_Comanda_ClientId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "AdresaPrincipala",
                newName: "ClientId");

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AdresaPrincipala_Client_ClientId",
                table: "AdresaPrincipala",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comanda_Client_ClientId",
                table: "Comanda",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recenzie_Client_ClientId",
                table: "Recenzie",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdresaPrincipala_Client_ClientId",
                table: "AdresaPrincipala");

            migrationBuilder.DropForeignKey(
                name: "FK_Comanda_Client_ClientId",
                table: "Comanda");

            migrationBuilder.DropForeignKey(
                name: "FK_Recenzie_Client_ClientId",
                table: "Recenzie");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Recenzie",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Recenzie_ClientId",
                table: "Recenzie",
                newName: "IX_Recenzie_UserId");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Comanda",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Comanda_ClientId",
                table: "Comanda",
                newName: "IX_Comanda_UserId");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "AdresaPrincipala",
                newName: "UserId");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenume = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AdresaPrincipala_User_UserId",
                table: "AdresaPrincipala",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comanda_User_UserId",
                table: "Comanda",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recenzie_User_UserId",
                table: "Recenzie",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
