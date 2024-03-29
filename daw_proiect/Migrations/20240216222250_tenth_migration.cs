﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace daw_proiect.Migrations
{
    /// <inheritdoc />
    public partial class tenth_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locatii");

            migrationBuilder.DropTable(
                name: "Recenzii");

            migrationBuilder.CreateTable(
                name: "Locatie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Oras = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Strada = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numar_cladire = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locatie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recenzie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nota = table.Column<int>(type: "int", nullable: false),
                    Comentariu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProdusId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recenzie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recenzie_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recenzie_Produs_ProdusId",
                        column: x => x.ProdusId,
                        principalTable: "Produs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reteta",
                columns: table => new
                {
                    ProdusId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Indicatii = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reteta", x => x.ProdusId);
                    table.ForeignKey(
                        name: "FK_Reteta_Produs_ProdusId",
                        column: x => x.ProdusId,
                        principalTable: "Produs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stoc",
                columns: table => new
                {
                    ProdusId = table.Column<int>(type: "int", nullable: false),
                    LocatieId = table.Column<int>(type: "int", nullable: false),
                    Cantitate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stoc", x => new { x.ProdusId, x.LocatieId });
                    table.ForeignKey(
                        name: "FK_Stoc_Locatie_LocatieId",
                        column: x => x.LocatieId,
                        principalTable: "Locatie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stoc_Produs_ProdusId",
                        column: x => x.ProdusId,
                        principalTable: "Produs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recenzie_ClientId",
                table: "Recenzie",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Recenzie_ProdusId",
                table: "Recenzie",
                column: "ProdusId");

            migrationBuilder.CreateIndex(
                name: "IX_Stoc_LocatieId",
                table: "Stoc",
                column: "LocatieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recenzie");

            migrationBuilder.DropTable(
                name: "Reteta");

            migrationBuilder.DropTable(
                name: "Stoc");

            migrationBuilder.DropTable(
                name: "Locatie");

            migrationBuilder.CreateTable(
                name: "Locatii",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numar_cladire = table.Column<int>(type: "int", nullable: false),
                    Oras = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Strada = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locatii", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recenzii",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    ProdusId = table.Column<int>(type: "int", nullable: false),
                    Comentariu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nota = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recenzii", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recenzii_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recenzii_Produs_ProdusId",
                        column: x => x.ProdusId,
                        principalTable: "Produs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recenzii_ClientId",
                table: "Recenzii",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Recenzii_ProdusId",
                table: "Recenzii",
                column: "ProdusId");
        }
    }
}
