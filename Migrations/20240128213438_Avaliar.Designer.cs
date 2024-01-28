﻿// <auto-generated />
using Controle_Jogos_API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Controle_Jogos_API.Migrations
{
    [DbContext(typeof(JogosContext))]
    [Migration("20240128213438_Avaliar")]
    partial class Avaliar
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Controle_Jogos_API.Entities.Jogo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AnoJogado")
                        .HasColumnType("int");

                    b.Property<string>("AnoLancamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Avaliar")
                        .HasColumnType("int");

                    b.Property<bool>("Finalizado")
                        .HasColumnType("bit");

                    b.Property<double>("HorasJogadas")
                        .HasColumnType("float");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UltimaAtualizacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Jogos");
                });
#pragma warning restore 612, 618
        }
    }
}
