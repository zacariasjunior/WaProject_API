﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WaProject_API.Infra.Context;

namespace WaProject_API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210429183929_2021_04_29_001")]
    partial class _2021_04_29_001
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WaProject_API.Models.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataDaEntregaRealizada")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DataDeCriacao")
                        .HasColumnType("datetime");

                    b.Property<string>("EnderecoEntregaRealizada")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Pedido");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataDaEntregaRealizada = new DateTime(2021, 5, 1, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(4193),
                            DataDeCriacao = new DateTime(2021, 4, 29, 15, 39, 28, 92, DateTimeKind.Local).AddTicks(384),
                            EnderecoEntregaRealizada = "Rua 6, Numero 79, Sao Paulo"
                        },
                        new
                        {
                            Id = 2,
                            DataDaEntregaRealizada = new DateTime(2021, 5, 1, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(6456),
                            DataDeCriacao = new DateTime(2021, 4, 30, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(6418),
                            EnderecoEntregaRealizada = "Rua 12, Numero 111, Sao Paulo"
                        },
                        new
                        {
                            Id = 3,
                            DataDaEntregaRealizada = new DateTime(2021, 5, 2, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(6510),
                            DataDeCriacao = new DateTime(2021, 5, 1, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(6507),
                            EnderecoEntregaRealizada = "Rua 7, Numero 103, Sao Paulo"
                        },
                        new
                        {
                            Id = 4,
                            DataDaEntregaRealizada = new DateTime(2021, 5, 3, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(6521),
                            DataDeCriacao = new DateTime(2021, 5, 2, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(6519),
                            EnderecoEntregaRealizada = "Rua 14, Numero 81, Sao Paulo"
                        },
                        new
                        {
                            Id = 5,
                            DataDaEntregaRealizada = new DateTime(2021, 5, 4, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(6531),
                            DataDeCriacao = new DateTime(2021, 5, 3, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(6529),
                            EnderecoEntregaRealizada = "Rua 16, Numero 113, Sao Paulo"
                        },
                        new
                        {
                            Id = 6,
                            DataDaEntregaRealizada = new DateTime(2021, 5, 5, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(6540),
                            DataDeCriacao = new DateTime(2021, 5, 4, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(6537),
                            EnderecoEntregaRealizada = "Rua 8, Numero 187, Sao Paulo"
                        },
                        new
                        {
                            Id = 7,
                            DataDaEntregaRealizada = new DateTime(2021, 5, 6, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(6548),
                            DataDeCriacao = new DateTime(2021, 5, 5, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(6547),
                            EnderecoEntregaRealizada = "Rua 14, Numero 122, Sao Paulo"
                        },
                        new
                        {
                            Id = 8,
                            DataDaEntregaRealizada = new DateTime(2021, 5, 7, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(6558),
                            DataDeCriacao = new DateTime(2021, 5, 6, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(6556),
                            EnderecoEntregaRealizada = "Rua 8, Numero 187, Sao Paulo"
                        },
                        new
                        {
                            Id = 9,
                            DataDaEntregaRealizada = new DateTime(2021, 5, 8, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(6568),
                            DataDeCriacao = new DateTime(2021, 5, 7, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(6565),
                            EnderecoEntregaRealizada = "Rua 11, Numero 87, Sao Paulo"
                        },
                        new
                        {
                            Id = 10,
                            DataDaEntregaRealizada = new DateTime(2021, 5, 9, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(6576),
                            DataDeCriacao = new DateTime(2021, 5, 8, 15, 39, 28, 93, DateTimeKind.Local).AddTicks(6574),
                            EnderecoEntregaRealizada = "Rua 8, Numero 188, Sao Paulo"
                        });
                });

            modelBuilder.Entity("WaProject_API.ValueObjects.Equipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(120)")
                        .HasMaxLength(120);

                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.Property<string>("PlacaDoVeiculo")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("PedidoId")
                        .IsUnique();

                    b.ToTable("Equipe");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "Equipe Cod - 8520 atendimento especial",
                            Nome = "Equipe Setor - 44",
                            PedidoId = 1,
                            PlacaDoVeiculo = "352-8071"
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "Equipe Cod - 5448 atendimento especial",
                            Nome = "Equipe Setor - 48",
                            PedidoId = 2,
                            PlacaDoVeiculo = "541-9281"
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "Equipe Cod - 5529 atendimento especial",
                            Nome = "Equipe Setor - 42",
                            PedidoId = 3,
                            PlacaDoVeiculo = "969-7555"
                        },
                        new
                        {
                            Id = 4,
                            Descricao = "Equipe Cod - 6169 atendimento especial",
                            Nome = "Equipe Setor - 42",
                            PedidoId = 4,
                            PlacaDoVeiculo = "659-4397"
                        },
                        new
                        {
                            Id = 5,
                            Descricao = "Equipe Cod - 3889 atendimento especial",
                            Nome = "Equipe Setor - 41",
                            PedidoId = 5,
                            PlacaDoVeiculo = "242-6190"
                        },
                        new
                        {
                            Id = 6,
                            Descricao = "Equipe Cod - 7219 atendimento especial",
                            Nome = "Equipe Setor - 48",
                            PedidoId = 6,
                            PlacaDoVeiculo = "488-2633"
                        },
                        new
                        {
                            Id = 7,
                            Descricao = "Equipe Cod - 3898 atendimento especial",
                            Nome = "Equipe Setor - 46",
                            PedidoId = 7,
                            PlacaDoVeiculo = "992-4984"
                        },
                        new
                        {
                            Id = 8,
                            Descricao = "Equipe Cod - 5852 atendimento especial",
                            Nome = "Equipe Setor - 48",
                            PedidoId = 8,
                            PlacaDoVeiculo = "750-6107"
                        },
                        new
                        {
                            Id = 9,
                            Descricao = "Equipe Cod - 5135 atendimento especial",
                            Nome = "Equipe Setor - 44",
                            PedidoId = 9,
                            PlacaDoVeiculo = "259-4776"
                        },
                        new
                        {
                            Id = 10,
                            Descricao = "Equipe Cod - 7901 atendimento especial",
                            Nome = "Equipe Setor - 49",
                            PedidoId = 10,
                            PlacaDoVeiculo = "595-8964"
                        });
                });

            modelBuilder.Entity("WaProject_API.ValueObjects.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(120)")
                        .HasMaxLength(120);

                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.ToTable("Produto");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "Tv LED Cod - 7597 Samsung",
                            Nome = "Tv LED Cod - 48",
                            PedidoId = 1,
                            Valor = 1912m
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "Tv LED Cod - 5196 Samsung",
                            Nome = "Tv LED Cod - 43",
                            PedidoId = 1,
                            Valor = 1720m
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "Tv LED Cod - 2914 Samsung",
                            Nome = "Tv LED Cod - 46",
                            PedidoId = 2,
                            Valor = 1863m
                        },
                        new
                        {
                            Id = 4,
                            Descricao = "Tv LED Cod - 7092 Samsung",
                            Nome = "Tv LED Cod - 40",
                            PedidoId = 2,
                            Valor = 1285m
                        },
                        new
                        {
                            Id = 5,
                            Descricao = "Tv LED Cod - 8277 Samsung",
                            Nome = "Tv LED Cod - 40",
                            PedidoId = 3,
                            Valor = 1065m
                        },
                        new
                        {
                            Id = 6,
                            Descricao = "Tv LED Cod - 5494 Samsung",
                            Nome = "Tv LED Cod - 46",
                            PedidoId = 3,
                            Valor = 1201m
                        },
                        new
                        {
                            Id = 7,
                            Descricao = "Tv LED Cod - 6134 Samsung",
                            Nome = "Tv LED Cod - 40",
                            PedidoId = 4,
                            Valor = 1499m
                        },
                        new
                        {
                            Id = 8,
                            Descricao = "Tv LED Cod - 2630 Samsung",
                            Nome = "Tv LED Cod - 41",
                            PedidoId = 4,
                            Valor = 1748m
                        },
                        new
                        {
                            Id = 9,
                            Descricao = "Tv LED Cod - 5171 Samsung",
                            Nome = "Tv LED Cod - 47",
                            PedidoId = 5,
                            Valor = 1289m
                        },
                        new
                        {
                            Id = 10,
                            Descricao = "Tv LED Cod - 4923 Samsung",
                            Nome = "Tv LED Cod - 47",
                            PedidoId = 5,
                            Valor = 1275m
                        },
                        new
                        {
                            Id = 11,
                            Descricao = "Tv LED Cod - 4445 Samsung",
                            Nome = "Tv LED Cod - 43",
                            PedidoId = 6,
                            Valor = 1718m
                        },
                        new
                        {
                            Id = 12,
                            Descricao = "Tv LED Cod - 6600 Samsung",
                            Nome = "Tv LED Cod - 42",
                            PedidoId = 6,
                            Valor = 1058m
                        },
                        new
                        {
                            Id = 13,
                            Descricao = "Tv LED Cod - 2777 Samsung",
                            Nome = "Tv LED Cod - 48",
                            PedidoId = 7,
                            Valor = 1622m
                        },
                        new
                        {
                            Id = 14,
                            Descricao = "Tv LED Cod - 6155 Samsung",
                            Nome = "Tv LED Cod - 49",
                            PedidoId = 7,
                            Valor = 1862m
                        },
                        new
                        {
                            Id = 15,
                            Descricao = "Tv LED Cod - 7214 Samsung",
                            Nome = "Tv LED Cod - 45",
                            PedidoId = 7,
                            Valor = 1822m
                        },
                        new
                        {
                            Id = 16,
                            Descricao = "Tv LED Cod - 4958 Samsung",
                            Nome = "Tv LED Cod - 44",
                            PedidoId = 8,
                            Valor = 1508m
                        },
                        new
                        {
                            Id = 17,
                            Descricao = "Tv LED Cod - 5368 Samsung",
                            Nome = "Tv LED Cod - 43",
                            PedidoId = 9,
                            Valor = 1847m
                        },
                        new
                        {
                            Id = 18,
                            Descricao = "Tv LED Cod - 7230 Samsung",
                            Nome = "Tv LED Cod - 47",
                            PedidoId = 10,
                            Valor = 1960m
                        },
                        new
                        {
                            Id = 19,
                            Descricao = "Tv LED Cod - 7240 Samsung",
                            Nome = "Tv LED Cod - 43",
                            PedidoId = 10,
                            Valor = 1709m
                        });
                });

            modelBuilder.Entity("WaProject_API.ValueObjects.Equipe", b =>
                {
                    b.HasOne("WaProject_API.Models.Pedido", null)
                        .WithOne("Equipe")
                        .HasForeignKey("WaProject_API.ValueObjects.Equipe", "PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WaProject_API.ValueObjects.Produto", b =>
                {
                    b.HasOne("WaProject_API.Models.Pedido", null)
                        .WithMany("Produtos")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
