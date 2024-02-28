﻿// <auto-generated />
using System;
using FisioMetric.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FisioMetric.Migrations
{
    [DbContext(typeof(SqliteDbContext))]
    [Migration("20240220011845_CreateDatabase")]
    partial class CreateDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("FisioMetric.Models.Entidades.Atividade", b =>
                {
                    b.Property<int>("IdAtividade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Alongamento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Aparelho")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClienteChegou")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClienteSaiu")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataAtividade")
                        .HasColumnType("TEXT");

                    b.Property<string>("Fisioterapeuta")
                        .HasColumnType("TEXT");

                    b.Property<string>("Fortalecimento")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("IdPaciente")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Mobilidade")
                        .HasColumnType("TEXT");

                    b.Property<string>("Observacoes")
                        .HasColumnType("TEXT");

                    b.HasKey("IdAtividade");

                    b.ToTable("atividades", (string)null);
                });

            modelBuilder.Entity("FisioMetric.Models.Entidades.Avaliacao", b =>
                {
                    b.Property<int>("RelatorioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AntecedenteCardiopatia")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AntecedenteDiabete")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AntecedenteHereditario")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AntecedenteHipertensao")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AntecedenteNeoplasias")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Conteudo")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataAtendimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("DiagClinico")
                        .HasColumnType("TEXT");

                    b.Property<string>("DiagFisioterapeutico")
                        .HasColumnType("TEXT");

                    b.Property<bool>("DoencaCardiaca")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("DoencaCovid")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("DoencaDermatologica")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("DoencaEndocrina")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("DoencaGastroIntestinal")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("DoencaMetabolica")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("DoencaNeurologicas")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("DoencaRespiratorias")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("DoencaVasculares")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("DoencaVisual")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Etilismo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ExameFisico")
                        .HasColumnType("TEXT");

                    b.Property<string>("HDA1")
                        .HasColumnType("TEXT");

                    b.Property<string>("HabitosAlimentacao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Medicacao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("ObjetivoTerapeutico")
                        .HasColumnType("TEXT");

                    b.Property<string>("ObsAntecedente")
                        .HasColumnType("TEXT");

                    b.Property<string>("ObsMedicacao")
                        .HasColumnType("TEXT");

                    b.Property<string>("ObservacaoDoenca")
                        .HasColumnType("TEXT");

                    b.Property<int>("PacienteId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("QueixaPrincipal")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Tabagismo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TratamentoAnterior")
                        .HasColumnType("TEXT");

                    b.HasKey("RelatorioId");

                    b.ToTable("avaliacoes", (string)null);
                });

            modelBuilder.Entity("FisioMetric.Models.Entidades.Paciente", b =>
                {
                    b.Property<int>("PacienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataUltimaAtividade")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataUltimaAvaliacao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Endereco")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Profissao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sexo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("PacienteId");

                    b.ToTable("pacientes", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
