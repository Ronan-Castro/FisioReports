using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FisioMetric.Migrations
{
    /// <inheritdoc />
    public partial class Update2240224 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Conteudo",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "ExameFisico",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "HabitosAlimentacao",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "ObsAntecedente",
                table: "avaliacoes");

            migrationBuilder.RenameColumn(
                name: "ObsMedicacao",
                table: "avaliacoes",
                newName: "ObsHabitos");

            migrationBuilder.RenameColumn(
                name: "DoencaVisual",
                table: "avaliacoes",
                newName: "Visual");

            migrationBuilder.RenameColumn(
                name: "DoencaVasculares",
                table: "avaliacoes",
                newName: "Vasculares");

            migrationBuilder.RenameColumn(
                name: "DoencaRespiratorias",
                table: "avaliacoes",
                newName: "Respiratorias");

            migrationBuilder.RenameColumn(
                name: "DoencaNeurologicas",
                table: "avaliacoes",
                newName: "Pilates");

            migrationBuilder.RenameColumn(
                name: "DoencaMetabolica",
                table: "avaliacoes",
                newName: "Neurologicas");

            migrationBuilder.RenameColumn(
                name: "DoencaGastroIntestinal",
                table: "avaliacoes",
                newName: "Neoplasias");

            migrationBuilder.RenameColumn(
                name: "DoencaEndocrina",
                table: "avaliacoes",
                newName: "Metabolica");

            migrationBuilder.RenameColumn(
                name: "DoencaDermatologica",
                table: "avaliacoes",
                newName: "Intestino");

            migrationBuilder.RenameColumn(
                name: "DoencaCovid",
                table: "avaliacoes",
                newName: "IngereAgua");

            migrationBuilder.RenameColumn(
                name: "DoencaCardiaca",
                table: "avaliacoes",
                newName: "Hipertensao");

            migrationBuilder.RenameColumn(
                name: "AntecedenteNeoplasias",
                table: "avaliacoes",
                newName: "Gestacao");

            migrationBuilder.RenameColumn(
                name: "AntecedenteHipertensao",
                table: "avaliacoes",
                newName: "GastroIntestinal");

            migrationBuilder.RenameColumn(
                name: "AntecedenteHereditario",
                table: "avaliacoes",
                newName: "Endocrina");

            migrationBuilder.RenameColumn(
                name: "AntecedenteDiabete",
                table: "avaliacoes",
                newName: "DoencasHereditarias");

            migrationBuilder.RenameColumn(
                name: "AntecedenteCardiopatia",
                table: "avaliacoes",
                newName: "Diabete");

            migrationBuilder.AlterColumn<bool>(
                name: "Medicacao",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "AtivFisica",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Cardiaca",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Cardiopatia",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Cirurgias",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Covid",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Dermatologica",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AtivFisica",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "Cardiaca",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "Cardiopatia",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "Cirurgias",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "Covid",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "Dermatologica",
                table: "avaliacoes");

            migrationBuilder.RenameColumn(
                name: "Visual",
                table: "avaliacoes",
                newName: "DoencaVisual");

            migrationBuilder.RenameColumn(
                name: "Vasculares",
                table: "avaliacoes",
                newName: "DoencaVasculares");

            migrationBuilder.RenameColumn(
                name: "Respiratorias",
                table: "avaliacoes",
                newName: "DoencaRespiratorias");

            migrationBuilder.RenameColumn(
                name: "Pilates",
                table: "avaliacoes",
                newName: "DoencaNeurologicas");

            migrationBuilder.RenameColumn(
                name: "ObsHabitos",
                table: "avaliacoes",
                newName: "ObsMedicacao");

            migrationBuilder.RenameColumn(
                name: "Neurologicas",
                table: "avaliacoes",
                newName: "DoencaMetabolica");

            migrationBuilder.RenameColumn(
                name: "Neoplasias",
                table: "avaliacoes",
                newName: "DoencaGastroIntestinal");

            migrationBuilder.RenameColumn(
                name: "Metabolica",
                table: "avaliacoes",
                newName: "DoencaEndocrina");

            migrationBuilder.RenameColumn(
                name: "Intestino",
                table: "avaliacoes",
                newName: "DoencaDermatologica");

            migrationBuilder.RenameColumn(
                name: "IngereAgua",
                table: "avaliacoes",
                newName: "DoencaCovid");

            migrationBuilder.RenameColumn(
                name: "Hipertensao",
                table: "avaliacoes",
                newName: "DoencaCardiaca");

            migrationBuilder.RenameColumn(
                name: "Gestacao",
                table: "avaliacoes",
                newName: "AntecedenteNeoplasias");

            migrationBuilder.RenameColumn(
                name: "GastroIntestinal",
                table: "avaliacoes",
                newName: "AntecedenteHipertensao");

            migrationBuilder.RenameColumn(
                name: "Endocrina",
                table: "avaliacoes",
                newName: "AntecedenteHereditario");

            migrationBuilder.RenameColumn(
                name: "DoencasHereditarias",
                table: "avaliacoes",
                newName: "AntecedenteDiabete");

            migrationBuilder.RenameColumn(
                name: "Diabete",
                table: "avaliacoes",
                newName: "AntecedenteCardiopatia");

            migrationBuilder.AlterColumn<string>(
                name: "Medicacao",
                table: "avaliacoes",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<string>(
                name: "Conteudo",
                table: "avaliacoes",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExameFisico",
                table: "avaliacoes",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HabitosAlimentacao",
                table: "avaliacoes",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ObsAntecedente",
                table: "avaliacoes",
                type: "TEXT",
                nullable: true);
        }
    }
}
