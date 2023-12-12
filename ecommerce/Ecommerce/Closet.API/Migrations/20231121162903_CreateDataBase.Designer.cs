﻿// <auto-generated />
using System;
using Closet.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Closet.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231121162903_CreateDataBase")]
    partial class CreateDataBase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("Closet.API.Models.CadastroUsuarioModel", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConfirmaSenha")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SobrenomeUsuario")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CadastroUsuarios");
                });

            modelBuilder.Entity("Closet.API.Models.CategoriaModel", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NomeCategoria")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("RoupaModelId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RoupaModelId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("Closet.API.Models.RoupaModel", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DescricaoRoupa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FotoRoupa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeRoupa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("PrecoRoupa")
                        .HasColumnType("REAL");

                    b.Property<int>("Quantidade")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Roupas");
                });

            modelBuilder.Entity("Closet.API.Models.UsuarioLoginModel", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UsuarioLogins");
                });

            modelBuilder.Entity("Closet.API.Models.CategoriaModel", b =>
                {
                    b.HasOne("Closet.API.Models.RoupaModel", null)
                        .WithMany("Categorias")
                        .HasForeignKey("RoupaModelId");
                });

            modelBuilder.Entity("Closet.API.Models.RoupaModel", b =>
                {
                    b.Navigation("Categorias");
                });
#pragma warning restore 612, 618
        }
    }
}
