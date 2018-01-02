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

            migrationBuilder.CreateTable(
                name: "CotizacionPersonas",
                columns: table => new
                {
                    CotizacionPersonaID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    cotizacioncorrelativoID = table.Column<int>(nullable: true),
                    personaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CotizacionPersonas", x => x.CotizacionPersonaID);
                    table.ForeignKey(
                        name: "FK_CotizacionPersonas_Cotizaciones_cotizacioncorrelativoID",
                        column: x => x.cotizacioncorrelativoID,
                        principalTable: "Cotizaciones",
                        principalColumn: "correlativoID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CotizacionPersonas_Personas_personaId",
                        column: x => x.personaId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CotizacionPersonas_cotizacioncorrelativoID",
                table: "CotizacionPersonas",
                column: "cotizacioncorrelativoID");

            migrationBuilder.CreateIndex(
                name: "IX_CotizacionPersonas_personaId",
                table: "CotizacionPersonas",
                column: "personaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CotizacionPersonas");

            migrationBuilder.DropTable(
                name: "Cotizaciones");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
