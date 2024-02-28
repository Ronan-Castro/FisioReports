using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FisioMetric.Migrations
{
    /// <inheritdoc />
    public partial class Update3240224 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sexo",
                table: "pacientes",
                newName: "Genero");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Genero",
                table: "pacientes",
                newName: "Sexo");
        }
    }
}
