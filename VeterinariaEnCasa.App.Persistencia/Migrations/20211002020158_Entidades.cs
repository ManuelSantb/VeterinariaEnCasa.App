using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VeterinariaEnCasa.App.Persistencia.Migrations
{
    public partial class Entidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "personas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "correoElectronico",
                table: "personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "horas_laborales",
                table: "personas",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tarjetaProfesional",
                table: "personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "historia",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    diagnostico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    entorno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sugerencia = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_historia", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "mascotas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    latitud = table.Column<float>(type: "real", nullable: false),
                    longitud = table.Column<float>(type: "real", nullable: false),
                    tipo_mascota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    raza = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    peso = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mascotas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "signoVital",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tipoSigno = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_signoVital", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sugerencia",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha_hora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sugerencia", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "historia");

            migrationBuilder.DropTable(
                name: "mascotas");

            migrationBuilder.DropTable(
                name: "signoVital");

            migrationBuilder.DropTable(
                name: "sugerencia");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "personas");

            migrationBuilder.DropColumn(
                name: "correoElectronico",
                table: "personas");

            migrationBuilder.DropColumn(
                name: "horas_laborales",
                table: "personas");

            migrationBuilder.DropColumn(
                name: "tarjetaProfesional",
                table: "personas");
        }
    }
}
