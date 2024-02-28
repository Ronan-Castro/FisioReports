using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FisioMetric.Migrations
{
    /// <inheritdoc />
    public partial class update270224 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Visual",
                table: "avaliacoes",
                newName: "DoencasCondicoes_Visual");

            migrationBuilder.RenameColumn(
                name: "Vasculares",
                table: "avaliacoes",
                newName: "DoencasCondicoes_Vasculares");

            migrationBuilder.RenameColumn(
                name: "Tabagismo",
                table: "avaliacoes",
                newName: "HabitosVida_Tabagismo");

            migrationBuilder.RenameColumn(
                name: "Respiratorias",
                table: "avaliacoes",
                newName: "DoencasCondicoes_Respiratorias");

            migrationBuilder.RenameColumn(
                name: "Pilates",
                table: "avaliacoes",
                newName: "HabitosVida_Pilates");

            migrationBuilder.RenameColumn(
                name: "ObsHabitos",
                table: "avaliacoes",
                newName: "HabitosVida_ObsHabitos");

            migrationBuilder.RenameColumn(
                name: "Neurologicas",
                table: "avaliacoes",
                newName: "DoencasCondicoes_Neurologicas");

            migrationBuilder.RenameColumn(
                name: "Neoplasias",
                table: "avaliacoes",
                newName: "DoencasCondicoes_Neoplasias");

            migrationBuilder.RenameColumn(
                name: "MobilidadeColuna",
                table: "avaliacoes",
                newName: "ExameFisico_MobilidadeColuna");

            migrationBuilder.RenameColumn(
                name: "Metabolica",
                table: "avaliacoes",
                newName: "DoencasCondicoes_Metabolica");

            migrationBuilder.RenameColumn(
                name: "Medicacao",
                table: "avaliacoes",
                newName: "HabitosVida_Medicacao");

            migrationBuilder.RenameColumn(
                name: "Intestino",
                table: "avaliacoes",
                newName: "HabitosVida_Intestino");

            migrationBuilder.RenameColumn(
                name: "IngereAgua",
                table: "avaliacoes",
                newName: "HabitosVida_IngereAgua");

            migrationBuilder.RenameColumn(
                name: "Hipertensao",
                table: "avaliacoes",
                newName: "DoencasCondicoes_Hipertensao");

            migrationBuilder.RenameColumn(
                name: "Gestacao",
                table: "avaliacoes",
                newName: "DoencasCondicoes_Gestacao");

            migrationBuilder.RenameColumn(
                name: "GastroIntestinal",
                table: "avaliacoes",
                newName: "DoencasCondicoes_GastroIntestinal");

            migrationBuilder.RenameColumn(
                name: "FroxidaoLigamentar",
                table: "avaliacoes",
                newName: "ExameFisico_FroxidaoLigamentar");

            migrationBuilder.RenameColumn(
                name: "Etilismo",
                table: "avaliacoes",
                newName: "HabitosVida_Etilismo");

            migrationBuilder.RenameColumn(
                name: "EstabilidadeEscapular",
                table: "avaliacoes",
                newName: "ExameFisico_EstabilidadeEscapular");

            migrationBuilder.RenameColumn(
                name: "Equilibrio",
                table: "avaliacoes",
                newName: "ExameFisico_Equilibrio");

            migrationBuilder.RenameColumn(
                name: "Endocrina",
                table: "avaliacoes",
                newName: "DoencasCondicoes_Endocrina");

            migrationBuilder.RenameColumn(
                name: "DoencasHereditarias",
                table: "avaliacoes",
                newName: "DoencasCondicoes_DoencasHereditarias");

            migrationBuilder.RenameColumn(
                name: "Diabete",
                table: "avaliacoes",
                newName: "DoencasCondicoes_Diabete");

            migrationBuilder.RenameColumn(
                name: "Dermatologica",
                table: "avaliacoes",
                newName: "DoencasCondicoes_Dermatologica");

            migrationBuilder.RenameColumn(
                name: "Covid",
                table: "avaliacoes",
                newName: "DoencasCondicoes_Covid");

            migrationBuilder.RenameColumn(
                name: "Cirurgias",
                table: "avaliacoes",
                newName: "DoencasCondicoes_Cirurgias");

            migrationBuilder.RenameColumn(
                name: "Cardiopatia",
                table: "avaliacoes",
                newName: "DoencasCondicoes_Cardiopatia");

            migrationBuilder.RenameColumn(
                name: "Cardiaca",
                table: "avaliacoes",
                newName: "DoencasCondicoes_Cardiaca");

            migrationBuilder.RenameColumn(
                name: "AtivFisica",
                table: "avaliacoes",
                newName: "HabitosVida_AtivFisica");

            migrationBuilder.RenameColumn(
                name: "Pes",
                table: "avaliacoes",
                newName: "ExameFisico_Pes_IsVaro");

            migrationBuilder.RenameColumn(
                name: "Pelve",
                table: "avaliacoes",
                newName: "ExameFisico_Pes_IsValgo");

            migrationBuilder.RenameColumn(
                name: "PadraoMovimento",
                table: "avaliacoes",
                newName: "ExameFisico_Pes_IsNormal");

            migrationBuilder.RenameColumn(
                name: "Ombros",
                table: "avaliacoes",
                newName: "ExameFisico_Pelve_IsRetroversao");

            migrationBuilder.RenameColumn(
                name: "Joelhos",
                table: "avaliacoes",
                newName: "ExameFisico_Pelve_IsNormal");

            migrationBuilder.RenameColumn(
                name: "Coluna",
                table: "avaliacoes",
                newName: "ExameFisico_Pelve_IsEscoliose");

            migrationBuilder.RenameColumn(
                name: "CabecaCervical",
                table: "avaliacoes",
                newName: "ExameFisico_Pelve_IsElevadoEsquerda");

            migrationBuilder.AddColumn<bool>(
                name: "ExameFisico_Cabeca_IsInclinadaDireita",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ExameFisico_Cabeca_IsInclinadaEsquerda",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ExameFisico_Cabeca_IsNormal",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ExameFisico_Cervical_IsAnteriorizada",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ExameFisico_Cervical_IsNormal",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ExameFisico_Cervical_IsRetificada",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ExameFisico_Coluna_IsEscoliose",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ExameFisico_Coluna_IsHipercifose",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ExameFisico_Coluna_IsHiperlordose",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ExameFisico_Coluna_IsNormal",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ExameFisico_Joelhos_IsNormal",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ExameFisico_Joelhos_IsValgo",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ExameFisico_Joelhos_IsVaro",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ExameFisico_Ombros_IsAnteriorizada",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ExameFisico_Ombros_IsElevadoDireito",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ExameFisico_Ombros_IsElevadoEsquerdo",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ExameFisico_Ombros_IsEscapulaAlada",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ExameFisico_Ombros_IsNormal",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ExameFisico_PadraoMovimento_IsMaleavel",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ExameFisico_PadraoMovimento_IsNormal",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ExameFisico_PadraoMovimento_IsRigido",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ExameFisico_Pelve_IsAnteversao",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ExameFisico_Pelve_IsElevadoDireita",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExameFisico_Cabeca_IsInclinadaDireita",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "ExameFisico_Cabeca_IsInclinadaEsquerda",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "ExameFisico_Cabeca_IsNormal",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "ExameFisico_Cervical_IsAnteriorizada",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "ExameFisico_Cervical_IsNormal",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "ExameFisico_Cervical_IsRetificada",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "ExameFisico_Coluna_IsEscoliose",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "ExameFisico_Coluna_IsHipercifose",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "ExameFisico_Coluna_IsHiperlordose",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "ExameFisico_Coluna_IsNormal",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "ExameFisico_Joelhos_IsNormal",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "ExameFisico_Joelhos_IsValgo",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "ExameFisico_Joelhos_IsVaro",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "ExameFisico_Ombros_IsAnteriorizada",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "ExameFisico_Ombros_IsElevadoDireito",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "ExameFisico_Ombros_IsElevadoEsquerdo",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "ExameFisico_Ombros_IsEscapulaAlada",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "ExameFisico_Ombros_IsNormal",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "ExameFisico_PadraoMovimento_IsMaleavel",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "ExameFisico_PadraoMovimento_IsNormal",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "ExameFisico_PadraoMovimento_IsRigido",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "ExameFisico_Pelve_IsAnteversao",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "ExameFisico_Pelve_IsElevadoDireita",
                table: "avaliacoes");

            migrationBuilder.RenameColumn(
                name: "HabitosVida_Tabagismo",
                table: "avaliacoes",
                newName: "Tabagismo");

            migrationBuilder.RenameColumn(
                name: "HabitosVida_Pilates",
                table: "avaliacoes",
                newName: "Pilates");

            migrationBuilder.RenameColumn(
                name: "HabitosVida_ObsHabitos",
                table: "avaliacoes",
                newName: "ObsHabitos");

            migrationBuilder.RenameColumn(
                name: "HabitosVida_Medicacao",
                table: "avaliacoes",
                newName: "Medicacao");

            migrationBuilder.RenameColumn(
                name: "HabitosVida_Intestino",
                table: "avaliacoes",
                newName: "Intestino");

            migrationBuilder.RenameColumn(
                name: "HabitosVida_IngereAgua",
                table: "avaliacoes",
                newName: "IngereAgua");

            migrationBuilder.RenameColumn(
                name: "HabitosVida_Etilismo",
                table: "avaliacoes",
                newName: "Etilismo");

            migrationBuilder.RenameColumn(
                name: "HabitosVida_AtivFisica",
                table: "avaliacoes",
                newName: "AtivFisica");

            migrationBuilder.RenameColumn(
                name: "ExameFisico_MobilidadeColuna",
                table: "avaliacoes",
                newName: "MobilidadeColuna");

            migrationBuilder.RenameColumn(
                name: "ExameFisico_FroxidaoLigamentar",
                table: "avaliacoes",
                newName: "FroxidaoLigamentar");

            migrationBuilder.RenameColumn(
                name: "ExameFisico_EstabilidadeEscapular",
                table: "avaliacoes",
                newName: "EstabilidadeEscapular");

            migrationBuilder.RenameColumn(
                name: "ExameFisico_Equilibrio",
                table: "avaliacoes",
                newName: "Equilibrio");

            migrationBuilder.RenameColumn(
                name: "DoencasCondicoes_Visual",
                table: "avaliacoes",
                newName: "Visual");

            migrationBuilder.RenameColumn(
                name: "DoencasCondicoes_Vasculares",
                table: "avaliacoes",
                newName: "Vasculares");

            migrationBuilder.RenameColumn(
                name: "DoencasCondicoes_Respiratorias",
                table: "avaliacoes",
                newName: "Respiratorias");

            migrationBuilder.RenameColumn(
                name: "DoencasCondicoes_Neurologicas",
                table: "avaliacoes",
                newName: "Neurologicas");

            migrationBuilder.RenameColumn(
                name: "DoencasCondicoes_Neoplasias",
                table: "avaliacoes",
                newName: "Neoplasias");

            migrationBuilder.RenameColumn(
                name: "DoencasCondicoes_Metabolica",
                table: "avaliacoes",
                newName: "Metabolica");

            migrationBuilder.RenameColumn(
                name: "DoencasCondicoes_Hipertensao",
                table: "avaliacoes",
                newName: "Hipertensao");

            migrationBuilder.RenameColumn(
                name: "DoencasCondicoes_Gestacao",
                table: "avaliacoes",
                newName: "Gestacao");

            migrationBuilder.RenameColumn(
                name: "DoencasCondicoes_GastroIntestinal",
                table: "avaliacoes",
                newName: "GastroIntestinal");

            migrationBuilder.RenameColumn(
                name: "DoencasCondicoes_Endocrina",
                table: "avaliacoes",
                newName: "Endocrina");

            migrationBuilder.RenameColumn(
                name: "DoencasCondicoes_DoencasHereditarias",
                table: "avaliacoes",
                newName: "DoencasHereditarias");

            migrationBuilder.RenameColumn(
                name: "DoencasCondicoes_Diabete",
                table: "avaliacoes",
                newName: "Diabete");

            migrationBuilder.RenameColumn(
                name: "DoencasCondicoes_Dermatologica",
                table: "avaliacoes",
                newName: "Dermatologica");

            migrationBuilder.RenameColumn(
                name: "DoencasCondicoes_Covid",
                table: "avaliacoes",
                newName: "Covid");

            migrationBuilder.RenameColumn(
                name: "DoencasCondicoes_Cirurgias",
                table: "avaliacoes",
                newName: "Cirurgias");

            migrationBuilder.RenameColumn(
                name: "DoencasCondicoes_Cardiopatia",
                table: "avaliacoes",
                newName: "Cardiopatia");

            migrationBuilder.RenameColumn(
                name: "DoencasCondicoes_Cardiaca",
                table: "avaliacoes",
                newName: "Cardiaca");

            migrationBuilder.RenameColumn(
                name: "ExameFisico_Pes_IsVaro",
                table: "avaliacoes",
                newName: "Pes");

            migrationBuilder.RenameColumn(
                name: "ExameFisico_Pes_IsValgo",
                table: "avaliacoes",
                newName: "Pelve");

            migrationBuilder.RenameColumn(
                name: "ExameFisico_Pes_IsNormal",
                table: "avaliacoes",
                newName: "PadraoMovimento");

            migrationBuilder.RenameColumn(
                name: "ExameFisico_Pelve_IsRetroversao",
                table: "avaliacoes",
                newName: "Ombros");

            migrationBuilder.RenameColumn(
                name: "ExameFisico_Pelve_IsNormal",
                table: "avaliacoes",
                newName: "Joelhos");

            migrationBuilder.RenameColumn(
                name: "ExameFisico_Pelve_IsEscoliose",
                table: "avaliacoes",
                newName: "Coluna");

            migrationBuilder.RenameColumn(
                name: "ExameFisico_Pelve_IsElevadoEsquerda",
                table: "avaliacoes",
                newName: "CabecaCervical");
        }
    }
}
