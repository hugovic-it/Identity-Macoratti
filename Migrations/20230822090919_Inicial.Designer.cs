﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcWebIdentity.Context;

#nullable disable

namespace MvcWebIdentity.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230822090919_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("MvcWebIdentity.Entities.Aluno", b =>
                {
                    b.Property<int>("AlunoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Curso")
                        .HasMaxLength(80)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("TEXT");

                    b.Property<int>("Idade")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("TEXT");

                    b.HasKey("AlunoId");

                    b.ToTable("Alunos");

                    b.HasData(
                        new
                        {
                            AlunoId = 1,
                            Curso = "Ciencia da computacao",
                            Email = "hugo@gmail.com",
                            Idade = 25,
                            Nome = "Hugo"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
