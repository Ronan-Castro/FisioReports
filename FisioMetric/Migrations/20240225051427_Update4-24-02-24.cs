using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FisioMetric.Migrations
{
    /// <inheritdoc />
    public partial class Update4240224 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Genero",
                table: "pacientes",
                newName: "Sexo");

            migrationBuilder.AddColumn<string>(
                name: "NovaColuna",
                table: "pacientes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NovaColuna",
                table: "pacientes");

            migrationBuilder.RenameColumn(
                name: "Sexo",
                table: "pacientes",
                newName: "Genero");
        }
    }
}
