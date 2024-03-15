﻿// <auto-generated />
using System;
using CrudCadastro.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CrudCadastro.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240314030220_inicial")]
    partial class inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CrudCadastro.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasMaxLength(3)
                        .HasColumnType("BIT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.ToTable("Categoria", (string)null);
                });

            modelBuilder.Entity("CrudCadastro.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasMaxLength(3)
                        .HasColumnType("BIT");

                    b.Property<DateTime>("DataValidade")
                        .HasMaxLength(20)
                        .HasColumnType("DATE");

                    b.Property<string>("Descricao")
                        .HasMaxLength(500)
                        .HasColumnType("VARCHAR");

                    b.Property<int>("Idcategoria")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("VARCHAR");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("Idcategoria");

                    b.ToTable("Produto", (string)null);
                });

            modelBuilder.Entity("CrudCadastro.Models.Produto", b =>
                {
                    b.HasOne("CrudCadastro.Models.Categoria", "Categoria")
                        .WithMany("Produto")
                        .HasForeignKey("Idcategoria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Categoria_Produto");

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("CrudCadastro.Models.Categoria", b =>
                {
                    b.Navigation("Produto");
                });
#pragma warning restore 612, 618
        }
    }
}
