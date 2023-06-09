﻿// <auto-generated />
using LeitorNfe.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LeitorNfe.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LeitorNfe.Models.Destinatario", b =>
                {
                    b.Property<int>("IDDestinatario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDDestinatario"));

                    b.Property<int>("IDEndereco")
                        .HasColumnType("int");

                    b.Property<int>("cnpj")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDDestinatario");

                    b.ToTable("Destinatarios");
                });

            modelBuilder.Entity("LeitorNfe.Models.Emitente", b =>
                {
                    b.Property<int>("IDEmitente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDEmitente"));

                    b.Property<int>("IDEndereco")
                        .HasColumnType("int");

                    b.Property<int>("cnpj")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDEmitente");

                    b.ToTable("Emitentes");
                });

            modelBuilder.Entity("LeitorNfe.Models.Endereco", b =>
                {
                    b.Property<int>("IDEndereco")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDEndereco"));

                    b.Property<string>("bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cep")
                        .HasColumnType("int");

                    b.Property<string>("logadouro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("municipio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numero")
                        .HasColumnType("int");

                    b.Property<string>("uf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDEndereco");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("LeitorNfe.Models.Nota", b =>
                {
                    b.Property<int>("IDNota")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDNota"));

                    b.Property<int>("IDDestinatario")
                        .HasColumnType("int");

                    b.Property<int>("IDEmitente")
                        .HasColumnType("int");

                    b.Property<int>("IDProduto")
                        .HasColumnType("int");

                    b.Property<string>("cAcesso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("comentario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dEmissao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("nNota")
                        .HasColumnType("int");

                    b.Property<int>("nPedidoCompra")
                        .HasColumnType("int");

                    b.Property<int>("totalNota")
                        .HasColumnType("int");

                    b.HasKey("IDNota");

                    b.ToTable("Notas");
                });

            modelBuilder.Entity("LeitorNfe.Models.Produto", b =>
                {
                    b.Property<int>("IDProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDProduto"));

                    b.Property<string>("cProduto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("nItem")
                        .HasColumnType("int");

                    b.Property<string>("nProduto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("qtdProduto")
                        .HasColumnType("int");

                    b.Property<int>("vTotalProduto")
                        .HasColumnType("int");

                    b.Property<int>("vUnitario")
                        .HasColumnType("int");

                    b.HasKey("IDProduto");

                    b.ToTable("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
