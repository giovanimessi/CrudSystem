﻿// <auto-generated />
using System;
using CrudSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CrudSystem.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    [Migration("20211228010757_LigacaoCargo")]
    partial class LigacaoCargo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CrudSystem.Models.Cargo", b =>
                {
                    b.Property<int>("CargoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome_Cargo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("departamentoCODIGO")
                        .HasColumnType("int");

                    b.HasKey("CargoId");

                    b.HasIndex("departamentoCODIGO");

                    b.ToTable("Cargo");
                });

            modelBuilder.Entity("CrudSystem.Models.Departamento", b =>
                {
                    b.Property<int>("CODIGO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NOME")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CODIGO");

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("CrudSystem.Models.Cargo", b =>
                {
                    b.HasOne("CrudSystem.Models.Departamento", "departamento")
                        .WithMany()
                        .HasForeignKey("departamentoCODIGO");

                    b.Navigation("departamento");
                });
#pragma warning restore 612, 618
        }
    }
}
