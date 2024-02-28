using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FisioMetric.Migrations
{
    /// <inheritdoc />
    public partial class Update2250224 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PacienteId",
                table: "avaliacoes",
                newName: "IdPaciente");

            migrationBuilder.RenameColumn(
                name: "RelatorioId",
                table: "avaliacoes",
                newName: "IdAvaliacao");

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "pacientes",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Sexo",
                table: "pacientes",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Profissao",
                table: "pacientes",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "pacientes",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Endereco",
                table: "pacientes",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "pacientes",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_evolucoes_IdPaciente",
                table: "evolucoes",
                column: "IdPaciente");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_avaliacoes_IdPaciente",
                table: "avaliacoes",
                column: "IdPaciente");

            migrationBuilder.AddForeignKey(
                name: "FK_avaliacoes_pacientes_IdPaciente",
                table: "avaliacoes",
                column: "IdPaciente",
                principalTable: "pacientes",
                principalColumn: "PacienteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_evolucoes_pacientes_IdPaciente",
                table: "evolucoes",
                column: "IdPaciente",
                principalTable: "pacientes",
                principalColumn: "PacienteId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_avaliacoes_pacientes_IdPaciente",
                table: "avaliacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_evolucoes_pacientes_IdPaciente",
                table: "evolucoes");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_evolucoes_IdPaciente",
                table: "evolucoes");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_avaliacoes_IdPaciente",
                table: "avaliacoes");

            migrationBuilder.RenameColumn(
                name: "IdPaciente",
                table: "avaliacoes",
                newName: "PacienteId");

            migrationBuilder.RenameColumn(
                name: "IdAvaliacao",
                table: "avaliacoes",
                newName: "RelatorioId");

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "pacientes",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Sexo",
                table: "pacientes",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Profissao",
                table: "pacientes",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "pacientes",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Endereco",
                table: "pacientes",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "pacientes",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }
    }
}
