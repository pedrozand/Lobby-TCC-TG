﻿// <auto-generated />
using DataBaseAPI.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace backend.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20231004182847_MigracaoUsuario")]
    partial class MigracaoUsuario
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QuadraAPI.Models.Quadra", b =>
                {
                    b.Property<int>("QuadraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuadraId"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("avaliacaoQuadra")
                        .HasColumnType("int");

                    b.Property<string>("endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("horarioFuncionamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("horarioLobby")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("imagem")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("latitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(350)");

                    b.Property<string>("longitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(350)");

                    b.Property<string>("modalidades")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");


                    b.HasKey("QuadraId");

                    b.ToTable("Quadras");
                });

            modelBuilder.Entity("UsuarioAPI.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("sobrenome")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("telefone")
                        .HasColumnType("int");

                    b.Property<bool>("ADM")
                    .IsRequired()
                    .HasColumnType("bit");    

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}