using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Investigacion.API.Migrations
{
    /// <inheritdoc />
    public partial class Inicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Investigadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreInvestiigadores = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AfiliacionInstitucional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Especializacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investigadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProyectoInvestigacions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FechaInicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fidelizacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LiderProyecto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreaInvestigacion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProyectoInvestigacions", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Investigadores_NombreInvestiigadores",
                table: "Investigadores",
                column: "NombreInvestiigadores",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProyectoInvestigacions_Nombre",
                table: "ProyectoInvestigacions",
                column: "Nombre",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Investigadores");

            migrationBuilder.DropTable(
                name: "ProyectoInvestigacions");
        }
    }
}
