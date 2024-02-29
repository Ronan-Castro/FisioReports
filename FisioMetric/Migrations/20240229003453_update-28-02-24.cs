using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FisioMetric.Migrations
{
    /// <inheritdoc />
    public partial class update280224 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExameFisico_PadraoMovimento_IsNormal",
                table: "avaliacoes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ExameFisico_PadraoMovimento_IsNormal",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
