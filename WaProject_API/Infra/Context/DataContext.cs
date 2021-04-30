using Microsoft.EntityFrameworkCore;
using System;
using WaProject_API.Infra.EntityConfig;
using WaProject_API.Models;
using WaProject_API.ValueObjects;

namespace WaProject_API.Infra.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Equipe> Equipe { get; set; }
        public DbSet<Produto> Produto { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {


            builder.ApplyConfiguration(new EquipeConfig());
            builder.ApplyConfiguration(new PedidoConfig());
            builder.ApplyConfiguration(new ProdutoConfig());

            var rng = new Random();

            if (true)
            {
                builder.Entity<Pedido>()
                 .HasData(
                     new Pedido { Id = 1, DataDeCriacao = DateTime.Now, DataDaEntregaRealizada = DateTime.Now.AddDays(2), EnderecoEntregaRealizada = $"Rua {rng.Next(1, 20)}, Numero {rng.Next(50, 200)}, Sao Paulo" },
                     new Pedido { Id = 2, DataDeCriacao = DateTime.Now.AddDays(1), DataDaEntregaRealizada = DateTime.Now.AddDays(2), EnderecoEntregaRealizada = $"Rua {rng.Next(1, 20)}, Numero {rng.Next(50, 200)}, Sao Paulo" },
                     new Pedido { Id = 3, DataDeCriacao = DateTime.Now.AddDays(2), DataDaEntregaRealizada = DateTime.Now.AddDays(3), EnderecoEntregaRealizada = $"Rua {rng.Next(1, 20)}, Numero {rng.Next(50, 200)}, Sao Paulo" },
                     new Pedido { Id = 4, DataDeCriacao = DateTime.Now.AddDays(3), DataDaEntregaRealizada = DateTime.Now.AddDays(4), EnderecoEntregaRealizada = $"Rua {rng.Next(1, 20)}, Numero {rng.Next(50, 200)}, Sao Paulo" },
                     new Pedido { Id = 5, DataDeCriacao = DateTime.Now.AddDays(4), DataDaEntregaRealizada = DateTime.Now.AddDays(5), EnderecoEntregaRealizada = $"Rua {rng.Next(1, 20)}, Numero {rng.Next(50, 200)}, Sao Paulo" },
                     new Pedido { Id = 6, DataDeCriacao = DateTime.Now.AddDays(5), DataDaEntregaRealizada = DateTime.Now.AddDays(6), EnderecoEntregaRealizada = $"Rua {rng.Next(1, 20)}, Numero {rng.Next(50, 200)}, Sao Paulo" },
                     new Pedido { Id = 7, DataDeCriacao = DateTime.Now.AddDays(6), DataDaEntregaRealizada = DateTime.Now.AddDays(7), EnderecoEntregaRealizada = $"Rua {rng.Next(1, 20)}, Numero {rng.Next(50, 200)}, Sao Paulo" },
                     new Pedido { Id = 8, DataDeCriacao = DateTime.Now.AddDays(7), DataDaEntregaRealizada = DateTime.Now.AddDays(8), EnderecoEntregaRealizada = $"Rua {rng.Next(1, 20)}, Numero {rng.Next(50, 200)}, Sao Paulo" },
                     new Pedido { Id = 9, DataDeCriacao = DateTime.Now.AddDays(8), DataDaEntregaRealizada = DateTime.Now.AddDays(9), EnderecoEntregaRealizada = $"Rua {rng.Next(1, 20)}, Numero {rng.Next(50, 200)}, Sao Paulo" },
                     new Pedido { Id = 10, DataDeCriacao = DateTime.Now.AddDays(9), DataDaEntregaRealizada = DateTime.Now.AddDays(10), EnderecoEntregaRealizada = $"Rua {rng.Next(1, 20)}, Numero {rng.Next(50, 200)}, Sao Paulo" }
                     );


                builder.Entity<Equipe>()
                            .HasData(
                    new Equipe { Id = 1, PedidoId = 1, Nome = $"Equipe Setor - {rng.Next(40, 50)}", Descricao = $"Equipe Cod - {rng.Next(2000, 9000)} atendimento especial", PlacaDoVeiculo = $"{rng.Next(100, 999)}-{rng.Next(2000, 9999)}" },
                    new Equipe { Id = 2, PedidoId = 2, Nome = $"Equipe Setor - {rng.Next(40, 50)}", Descricao = $"Equipe Cod - {rng.Next(2000, 9000)} atendimento especial", PlacaDoVeiculo = $"{rng.Next(100, 999)}-{rng.Next(2000, 9999)}" },
                    new Equipe { Id = 3, PedidoId = 3, Nome = $"Equipe Setor - {rng.Next(40, 50)}", Descricao = $"Equipe Cod - {rng.Next(2000, 9000)} atendimento especial", PlacaDoVeiculo = $"{rng.Next(100, 999)}-{rng.Next(2000, 9999)}" },
                    new Equipe { Id = 4, PedidoId = 4, Nome = $"Equipe Setor - {rng.Next(40, 50)}", Descricao = $"Equipe Cod - {rng.Next(2000, 9000)} atendimento especial", PlacaDoVeiculo = $"{rng.Next(100, 999)}-{rng.Next(2000, 9999)}" },
                    new Equipe { Id = 5, PedidoId = 5, Nome = $"Equipe Setor - {rng.Next(40, 50)}", Descricao = $"Equipe Cod - {rng.Next(2000, 9000)} atendimento especial", PlacaDoVeiculo = $"{rng.Next(100, 999)}-{rng.Next(2000, 9999)}" },
                    new Equipe { Id = 6, PedidoId = 6, Nome = $"Equipe Setor - {rng.Next(40, 50)}", Descricao = $"Equipe Cod - {rng.Next(2000, 9000)} atendimento especial", PlacaDoVeiculo = $"{rng.Next(100, 999)}-{rng.Next(2000, 9999)}" },
                    new Equipe { Id = 7, PedidoId = 7, Nome = $"Equipe Setor - {rng.Next(40, 50)}", Descricao = $"Equipe Cod - {rng.Next(2000, 9000)} atendimento especial", PlacaDoVeiculo = $"{rng.Next(100, 999)}-{rng.Next(2000, 9999)}" },
                    new Equipe { Id = 8, PedidoId = 8, Nome = $"Equipe Setor - {rng.Next(40, 50)}", Descricao = $"Equipe Cod - {rng.Next(2000, 9000)} atendimento especial", PlacaDoVeiculo = $"{rng.Next(100, 999)}-{rng.Next(2000, 9999)}" },
                    new Equipe { Id = 9, PedidoId = 9, Nome = $"Equipe Setor - {rng.Next(40, 50)}", Descricao = $"Equipe Cod - {rng.Next(2000, 9000)} atendimento especial", PlacaDoVeiculo = $"{rng.Next(100, 999)}-{rng.Next(2000, 9999)}" },
                    new Equipe { Id = 10, PedidoId = 10, Nome = $"Equipe Setor - {rng.Next(40, 50)}", Descricao = $"Equipe Cod - {rng.Next(2000, 9000)} atendimento especial", PlacaDoVeiculo = $"{rng.Next(100, 999)}-{rng.Next(2000, 9999)}" }

                    );

                builder.Entity<Produto>()
                          .HasData(
                    new Produto { Id = 1, PedidoId = 1, Nome = $"Tv LED Cod - {rng.Next(40, 50)}", Descricao = $"Tv LED Cod - {rng.Next(2000, 9000)} Samsung", Valor = Convert.ToDecimal(rng.Next(1000, 2000)) },
                    new Produto { Id = 2, PedidoId = 1, Nome = $"Tv LED Cod - {rng.Next(40, 50)}", Descricao = $"Tv LED Cod - {rng.Next(2000, 9000)} Samsung", Valor = Convert.ToDecimal(rng.Next(1000, 2000)) },
                    new Produto { Id = 3, PedidoId = 2, Nome = $"Tv LED Cod - {rng.Next(40, 50)}", Descricao = $"Tv LED Cod - {rng.Next(2000, 9000)} Samsung", Valor = Convert.ToDecimal(rng.Next(1000, 2000)) },
                    new Produto { Id = 4, PedidoId = 2, Nome = $"Tv LED Cod - {rng.Next(40, 50)}", Descricao = $"Tv LED Cod - {rng.Next(2000, 9000)} Samsung", Valor = Convert.ToDecimal(rng.Next(1000, 2000)) },
                    new Produto { Id = 5, PedidoId = 3, Nome = $"Tv LED Cod - {rng.Next(40, 50)}", Descricao = $"Tv LED Cod - {rng.Next(2000, 9000)} Samsung", Valor = Convert.ToDecimal(rng.Next(1000, 2000)) },
                    new Produto { Id = 6, PedidoId = 3, Nome = $"Tv LED Cod - {rng.Next(40, 50)}", Descricao = $"Tv LED Cod - {rng.Next(2000, 9000)} Samsung", Valor = Convert.ToDecimal(rng.Next(1000, 2000)) },
                    new Produto { Id = 7, PedidoId = 4, Nome = $"Tv LED Cod - {rng.Next(40, 50)}", Descricao = $"Tv LED Cod - {rng.Next(2000, 9000)} Samsung", Valor = Convert.ToDecimal(rng.Next(1000, 2000)) },
                    new Produto { Id = 8, PedidoId = 4, Nome = $"Tv LED Cod - {rng.Next(40, 50)}", Descricao = $"Tv LED Cod - {rng.Next(2000, 9000)} Samsung", Valor = Convert.ToDecimal(rng.Next(1000, 2000)) },
                    new Produto { Id = 9, PedidoId = 5, Nome = $"Tv LED Cod - {rng.Next(40, 50)}", Descricao = $"Tv LED Cod - {rng.Next(2000, 9000)} Samsung", Valor = Convert.ToDecimal(rng.Next(1000, 2000)) },
                    new Produto { Id = 10, PedidoId = 5, Nome = $"Tv LED Cod - {rng.Next(40, 50)}", Descricao = $"Tv LED Cod - {rng.Next(2000, 9000)} Samsung", Valor = Convert.ToDecimal(rng.Next(1000, 2000)) },
                    new Produto { Id = 11, PedidoId = 6, Nome = $"Tv LED Cod - {rng.Next(40, 50)}", Descricao = $"Tv LED Cod - {rng.Next(2000, 9000)} Samsung", Valor = Convert.ToDecimal(rng.Next(1000, 2000)) },
                    new Produto { Id = 12, PedidoId = 6, Nome = $"Tv LED Cod - {rng.Next(40, 50)}", Descricao = $"Tv LED Cod - {rng.Next(2000, 9000)} Samsung", Valor = Convert.ToDecimal(rng.Next(1000, 2000)) },
                    new Produto { Id = 13, PedidoId = 7, Nome = $"Tv LED Cod - {rng.Next(40, 50)}", Descricao = $"Tv LED Cod - {rng.Next(2000, 9000)} Samsung", Valor = Convert.ToDecimal(rng.Next(1000, 2000)) },
                    new Produto { Id = 14, PedidoId = 7, Nome = $"Tv LED Cod - {rng.Next(40, 50)}", Descricao = $"Tv LED Cod - {rng.Next(2000, 9000)} Samsung", Valor = Convert.ToDecimal(rng.Next(1000, 2000)) },
                    new Produto { Id = 15, PedidoId = 7, Nome = $"Tv LED Cod - {rng.Next(40, 50)}", Descricao = $"Tv LED Cod - {rng.Next(2000, 9000)} Samsung", Valor = Convert.ToDecimal(rng.Next(1000, 2000)) },
                    new Produto { Id = 16, PedidoId = 8, Nome = $"Tv LED Cod - {rng.Next(40, 50)}", Descricao = $"Tv LED Cod - {rng.Next(2000, 9000)} Samsung", Valor = Convert.ToDecimal(rng.Next(1000, 2000)) },
                    new Produto { Id = 17, PedidoId = 9, Nome = $"Tv LED Cod - {rng.Next(40, 50)}", Descricao = $"Tv LED Cod - {rng.Next(2000, 9000)} Samsung", Valor = Convert.ToDecimal(rng.Next(1000, 2000)) },
                    new Produto { Id = 18, PedidoId = 10, Nome = $"Tv LED Cod - {rng.Next(40, 50)}", Descricao = $"Tv LED Cod - {rng.Next(2000, 9000)} Samsung", Valor = Convert.ToDecimal(rng.Next(1000, 2000)) },
                    new Produto { Id = 19, PedidoId = 10, Nome = $"Tv LED Cod - {rng.Next(40, 50)}", Descricao = $"Tv LED Cod - {rng.Next(2000, 9000)} Samsung", Valor = Convert.ToDecimal(rng.Next(1000, 2000)) }
                          );
            }

           

            //if (true)
            //{


            //    for (int i = 1; i < 210; i++)
            //    {
            //        builder.Entity<Pedido>()
            //       .HasData(
            //           new Pedido { Id = i + 1, DataDeCriacao = DateTime.Now, DataDaEntregaRealizada = DateTime.Now.AddDays(2), EnderecoEntregaRealizada = $"Rua {rng.Next(1, 20)}, Numero {rng.Next(50, 200)}, Sao Paulo" });


            //        builder.Entity<Equipe>()
            //                .HasData(new Equipe { Id = i, PedidoId = i, Nome = $"Equipe Setor - {rng.Next(40, 50)}", Descricao = $"Equipe Cod - {rng.Next(2000, 9000)} atendimento especial" });


            //        //for (int i2 = 0; i2 < rng.Next(1, 5); i2++)
            //        //{
            //        //    builder.Entity<Produto>()
            //        //        .HasData(new Produto { PedidoId = i, Nome = $"Tv LED Cod - {rng.Next(40, 50)}", Descricao = $"Tv LED Cod - {rng.Next(2000, 9000)} Samsung" });

            //        //}
            //    }
            //}


        }

    }
}
