using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClasesEjercicioPrueba.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "listaClientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_listaClientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "listaPeluqueros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_listaPeluqueros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "listaServicios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_listaServicios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "listaTurnos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PeluqueroId = table.Column<int>(type: "int", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    ServicioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_listaTurnos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_listaTurnos_listaClientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "listaClientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_listaTurnos_listaPeluqueros_PeluqueroId",
                        column: x => x.PeluqueroId,
                        principalTable: "listaPeluqueros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_listaTurnos_listaServicios_ServicioId",
                        column: x => x.ServicioId,
                        principalTable: "listaServicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_listaTurnos_ClienteId",
                table: "listaTurnos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_listaTurnos_PeluqueroId",
                table: "listaTurnos",
                column: "PeluqueroId");

            migrationBuilder.CreateIndex(
                name: "IX_listaTurnos_ServicioId",
                table: "listaTurnos",
                column: "ServicioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "listaTurnos");

            migrationBuilder.DropTable(
                name: "listaClientes");

            migrationBuilder.DropTable(
                name: "listaPeluqueros");

            migrationBuilder.DropTable(
                name: "listaServicios");
        }
    }
}
