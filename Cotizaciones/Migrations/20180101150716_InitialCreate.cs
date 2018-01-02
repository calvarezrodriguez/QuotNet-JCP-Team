using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Cotizaciones.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cotizaciones",
                columns: table => new
                {
                    correlativoID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    descripcion = table.Column<string>(nullable: true),
                    estado = table.Column<string>(nullable: true),
                    fecha = table.Column<string>(nullable: true),
                    montoTotal = table.Column<int>(nullable: false),
                    tipoServicio = table.Column<string>(nullable: true),
                    valorAgregado = table.Column<int>(nullable: false),
                    version = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cotizaciones", x => x.correlativoID);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Materno = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Paterno = table.Column<string>(nullable: true),
                    Rut = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cotizaciones");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
