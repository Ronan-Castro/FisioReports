using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FisioMetric.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "atividades",
                columns: table => new
                {
                    IdAtividade = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdPaciente = table.Column<int>(type: "INTEGER", nullable: false),
                    DataAtividade = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Aparelho = table.Column<string>(type: "TEXT", nullable: true),
                    Fortalecimento = table.Column<string>(type: "TEXT", nullable: false),
                    Alongamento = table.Column<string>(type: "TEXT", nullable: true),
                    Mobilidade = table.Column<string>(type: "TEXT", nullable: true),
                    Observacoes = table.Column<string>(type: "TEXT", nullable: true),
                    ClienteChegou = table.Column<string>(type: "TEXT", nullable: true),
                    ClienteSaiu = table.Column<string>(type: "TEXT", nullable: true),
                    Fisioterapeuta = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_atividades", x => x.IdAtividade);
                });

            migrationBuilder.CreateTable(
                name: "avaliacoes",
                columns: table => new
                {
                    RelatorioId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PacienteId = table.Column<int>(type: "INTEGER", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Conteudo = table.Column<string>(type: "TEXT", nullable: true),
                    DataAtendimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DiagClinico = table.Column<string>(type: "TEXT", nullable: true),
                    DiagFisioterapeutico = table.Column<string>(type: "TEXT", nullable: true),
                    QueixaPrincipal = table.Column<string>(type: "TEXT", nullable: true),
                    HDA1 = table.Column<string>(type: "TEXT", nullable: true),
                    DoencaMetabolica = table.Column<bool>(type: "INTEGER", nullable: false),
                    DoencaCardiaca = table.Column<bool>(type: "INTEGER", nullable: false),
                    DoencaRespiratorias = table.Column<bool>(type: "INTEGER", nullable: false),
                    DoencaVasculares = table.Column<bool>(type: "INTEGER", nullable: false),
                    DoencaNeurologicas = table.Column<bool>(type: "INTEGER", nullable: false),
                    DoencaEndocrina = table.Column<bool>(type: "INTEGER", nullable: false),
                    DoencaDermatologica = table.Column<bool>(type: "INTEGER", nullable: false),
                    DoencaGastroIntestinal = table.Column<bool>(type: "INTEGER", nullable: false),
                    DoencaVisual = table.Column<bool>(type: "INTEGER", nullable: false),
                    DoencaCovid = table.Column<bool>(type: "INTEGER", nullable: false),
                    ObservacaoDoenca = table.Column<string>(type: "TEXT", nullable: true),
                    AntecedenteDiabete = table.Column<bool>(type: "INTEGER", nullable: false),
                    AntecedenteHipertensao = table.Column<bool>(type: "INTEGER", nullable: false),
                    AntecedenteCardiopatia = table.Column<bool>(type: "INTEGER", nullable: false),
                    AntecedenteNeoplasias = table.Column<bool>(type: "INTEGER", nullable: false),
                    AntecedenteHereditario = table.Column<bool>(type: "INTEGER", nullable: false),
                    ObsAntecedente = table.Column<string>(type: "TEXT", nullable: true),
                    Tabagismo = table.Column<bool>(type: "INTEGER", nullable: false),
                    Etilismo = table.Column<bool>(type: "INTEGER", nullable: false),
                    Medicacao = table.Column<string>(type: "TEXT", nullable: true),
                    ObsMedicacao = table.Column<string>(type: "TEXT", nullable: true),
                    HabitosAlimentacao = table.Column<string>(type: "TEXT", nullable: true),
                    TratamentoAnterior = table.Column<string>(type: "TEXT", nullable: true),
                    ObjetivoTerapeutico = table.Column<string>(type: "TEXT", nullable: true),
                    ExameFisico = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_avaliacoes", x => x.RelatorioId);
                });

            migrationBuilder.CreateTable(
                name: "pacientes",
                columns: table => new
                {
                    PacienteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Telefone = table.Column<string>(type: "TEXT", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Profissao = table.Column<string>(type: "TEXT", nullable: true),
                    DataUltimaAvaliacao = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataUltimaAtividade = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Sexo = table.Column<string>(type: "TEXT", nullable: true),
                    Endereco = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pacientes", x => x.PacienteId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "atividades");

            migrationBuilder.DropTable(
                name: "avaliacoes");

            migrationBuilder.DropTable(
                name: "pacientes");
        }
    }
}
