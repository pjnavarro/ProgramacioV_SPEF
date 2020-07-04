using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ACTI.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profesor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Apellido = table.Column<string>(nullable: false),
                    Dirección = table.Column<string>(nullable: false),
                    Dni = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Estado = table.Column<bool>(nullable: false),
                    FechaCreacion = table.Column<DateTimeOffset>(nullable: false),
                    FechaModificacion = table.Column<DateTimeOffset>(nullable: false),
                    Nacimiento = table.Column<DateTime>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Teléfono = table.Column<int>(nullable: false),
                    UsuarioCreacion = table.Column<string>(nullable: true),
                    UsuarioModificacion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Alumno",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Apellido = table.Column<string>(nullable: false),
                    Dirección = table.Column<string>(nullable: false),
                    Dni = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Estado = table.Column<bool>(nullable: false),
                    FechaCreacion = table.Column<DateTimeOffset>(nullable: false),
                    FechaModificacion = table.Column<DateTimeOffset>(nullable: false),
                    Nacimiento = table.Column<DateTime>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    ProfesorId = table.Column<int>(nullable: true),
                    Teléfono = table.Column<int>(nullable: false),
                    UsuarioCreacion = table.Column<string>(nullable: true),
                    UsuarioModificacion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumno", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alumno_Profesor_ProfesorId",
                        column: x => x.ProfesorId,
                        principalTable: "Profesor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alumno_ProfesorId",
                table: "Alumno",
                column: "ProfesorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alumno");

            migrationBuilder.DropTable(
                name: "Profesor");
        }
    }
}
