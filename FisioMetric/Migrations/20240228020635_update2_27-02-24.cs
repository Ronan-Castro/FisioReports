using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FisioMetric.Migrations
{
    /// <inheritdoc />
    public partial class update2_270224 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_evolucoes_IdPaciente",
                table: "evolucoes");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_avaliacoes_IdPaciente",
                table: "avaliacoes");

            migrationBuilder.CreateIndex(
                name: "IX_evolucoes_IdPaciente",
                table: "evolucoes",
                column: "IdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_avaliacoes_IdPaciente",
                table: "avaliacoes",
                column: "IdPaciente");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_evolucoes_IdPaciente",
                table: "evolucoes");

            migrationBuilder.DropIndex(
                name: "IX_avaliacoes_IdPaciente",
                table: "avaliacoes");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_evolucoes_IdPaciente",
                table: "evolucoes",
                column: "IdPaciente");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_avaliacoes_IdPaciente",
                table: "avaliacoes",
                column: "IdPaciente");
        }
    }
}
