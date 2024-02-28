using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FisioMetric.Migrations
{
    /// <inheritdoc />
    public partial class Update1240224 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "atividades");

            migrationBuilder.DropColumn(
                name: "HDA1",
                table: "avaliacoes");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "avaliacoes",
                newName: "ObjetivoPessoal");

            migrationBuilder.AddColumn<int>(
                name: "CabecaCervical",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Coluna",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Equilibrio",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EstabilidadeEscapular",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FroxidaoLigamentar",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Joelhos",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "MobilidadeColuna",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Ombros",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PadraoMovimento",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Pelve",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Pes",
                table: "avaliacoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "evolucoes",
                columns: table => new
                {
                    IdEvolucao = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdPaciente = table.Column<int>(type: "INTEGER", nullable: false),
                    DataAtividade = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Aparelho = table.Column<string>(type: "TEXT", nullable: true),
                    Anotacoes = table.Column<string>(type: "TEXT", nullable: true),
                    ClienteChegou = table.Column<string>(type: "TEXT", nullable: true),
                    ClienteSaiu = table.Column<string>(type: "TEXT", nullable: true),
                    Fisioterapeuta = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_evolucoes", x => x.IdEvolucao);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "evolucoes");

            migrationBuilder.DropColumn(
                name: "CabecaCervical",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "Coluna",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "Equilibrio",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "EstabilidadeEscapular",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "FroxidaoLigamentar",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "Joelhos",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "MobilidadeColuna",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "Ombros",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "PadraoMovimento",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "Pelve",
                table: "avaliacoes");

            migrationBuilder.DropColumn(
                name: "Pes",
                table: "avaliacoes");

            migrationBuilder.RenameColumn(
                name: "ObjetivoPessoal",
                table: "avaliacoes",
                newName: "Nome");

            migrationBuilder.AddColumn<string>(
                name: "HDA1",
                table: "avaliacoes",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "atividades",
                columns: table => new
                {
                    IdAtividade = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Alongamento = table.Column<string>(type: "TEXT", nullable: true),
                    Aparelho = table.Column<string>(type: "TEXT", nullable: true),
                    ClienteChegou = table.Column<string>(type: "TEXT", nullable: true),
                    ClienteSaiu = table.Column<string>(type: "TEXT", nullable: true),
                    DataAtividade = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Fisioterapeuta = table.Column<string>(type: "TEXT", nullable: true),
                    Fortalecimento = table.Column<string>(type: "TEXT", nullable: false),
                    IdPaciente = table.Column<int>(type: "INTEGER", nullable: false),
                    Mobilidade = table.Column<string>(type: "TEXT", nullable: true),
                    Observacoes = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_atividades", x => x.IdAtividade);
                });
        }
    }
}
