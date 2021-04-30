using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WaProject_API.Dto;
using WaProject_API.Infra.Repository.Interface;
using WaProject_API.Models;
using WaProject_API.ValueObjects;

namespace WaProject_API.Infra.Repository
{
    public class PedidoAdoRepository : IPedidoAdoRepository
    {
        public List<Pedido> ListarTodosPedidosComEquipeProdutos(int pageNum, int pageSize)
        {
            var retorno = new List<Pedido>();
                       
            var produtos = ListarProdutos();

            var connectionString = BaseAdo.ConennectionString();

            var query = "SELECT * FROM Pedido " +
                        $" ORDER BY DataDeCriacao LIMIT {pageSize * (pageNum - 1)} , {pageSize}";

            using var connection = new MySqlConnection(connectionString);

            if (connection.State == ConnectionState.Closed)
                connection.Open();

            var command = new MySqlCommand(query, connection) { CommandType = CommandType.Text };

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var pedidoId = Convert.ToInt32(reader["Id"]);                   

                    var retornoAdd = new Pedido
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        DataDeCriacao = Convert.ToDateTime(reader["DataDeCriacao"]),
                        DataDaEntregaRealizada = Convert.ToDateTime(reader["DataDaEntregaRealizada"]),
                        EnderecoEntregaRealizada = reader["EnderecoEntregaRealizada"].ToString(),
                        Produtos = produtos.Where(x => x.PedidoId == pedidoId),
                        Equipe = ObterEquipeDoPedido(Convert.ToInt32(reader["Id"]))
                    };

                    retorno.Add(retornoAdd);
                }
            }

            if (connection.State == ConnectionState.Open)
                connection.Close();


            return retorno;

        }

        public List<Produto> ListarProdutos()
        {
            var retorno = new List<Produto>();

            var connectionString = BaseAdo.ConennectionString();

            var query = "SELECT * FROM Produto";

            using var connection = new MySqlConnection(connectionString);

            if (connection.State == ConnectionState.Closed)
                connection.Open();

            var command = new MySqlCommand(query, connection) { CommandType = CommandType.Text };

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var retornoAdd = new Produto
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        PedidoId = Convert.ToInt32(reader["PedidoId"]),
                        Nome = reader["Nome"].ToString(),
                        Descricao = reader["Descricao"].ToString(),
                        Valor = Convert.ToDecimal(reader["Valor"])
                    };

                    retorno.Add(retornoAdd);
                }
            }
            connection.Close();

            return retorno;

        }
        public List<Produto> ListarProdutoDoPedido(int pedidoId)
        {
            var retorno = new List<Produto>();

            var connectionString = BaseAdo.ConennectionString();

            var query = "SELECT * FROM Produto " +
                        $"where PedidoId  = {pedidoId}";

            using var connection = new MySqlConnection(connectionString);

            if (connection.State == ConnectionState.Closed)
                connection.Open();

            var command = new MySqlCommand(query, connection) { CommandType = CommandType.Text };

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var retornoAdd = new Produto
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Nome = reader["Nome"].ToString(),
                        Descricao = reader["Descricao"].ToString(),
                        Valor = Convert.ToDecimal(reader["Valor"])
                    };

                    retorno.Add(retornoAdd);
                }
            }
            connection.Close();

            return retorno;

        }

        public Equipe ListarEquipes()
        {
            var retorno = new Equipe();

            var connectionString = BaseAdo.ConennectionString();

            var query = "SELECT * FROM Equipe";

            using var connection = new MySqlConnection(connectionString);

            if (connection.State == ConnectionState.Closed)
                connection.Open();

            var command = new MySqlCommand(query, connection) { CommandType = CommandType.Text };

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var retornoAdd = new Equipe
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Nome = reader["Nome"].ToString(),
                        Descricao = reader["Descricao"].ToString(),
                        PlacaDoVeiculo = reader["PlacaDoVeiculo"].ToString()
                    };

                    retorno = retornoAdd;
                }
            }
            connection.Close();

            return retorno;

        }
        
        public Equipe ObterEquipeDoPedido(int pedidoId)
        {
            var retorno = new Equipe();

            var connectionString = BaseAdo.ConennectionString();

            var query = "SELECT * FROM Equipe " +
                        $"where PedidoId  = {pedidoId}";

            using var connection = new MySqlConnection(connectionString);

            if (connection.State == ConnectionState.Closed)
                connection.Open();

            var command = new MySqlCommand(query, connection) { CommandType = CommandType.Text };

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var retornoAdd = new Equipe
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Nome = reader["Nome"].ToString(),
                        Descricao = reader["Descricao"].ToString(),
                        PlacaDoVeiculo = reader["PlacaDoVeiculo"].ToString()
                    };

                    retorno = retornoAdd;
                }
            }
            connection.Close();

            return retorno;

        }

        public int TotalDePedidos()
        {
            var retorno = 0;

            var connectionString = BaseAdo.ConennectionString();

            var query = "SELECT COUNT(Id) As Quantidade FROM Pedido ";

            using var connection = new MySqlConnection(connectionString);

            if (connection.State == ConnectionState.Closed)
                connection.Open();

            var command = new MySqlCommand(query, connection) { CommandType = CommandType.Text };

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    retorno = Convert.ToInt32(reader["Quantidade"]);

                }
            }
            connection.Close();

            return retorno;

        }

        public List<EntregaPorDia> ListarEntregaPorDiaPeriodo30Dias()
        {
            var retorno = new List<EntregaPorDia>();

            var connectionString = BaseAdo.ConennectionString();

            var query = "SELECT DataDaEntregaRealizada, COUNT(Id) As Quantidade " +
                "FROM Pedido " +
                $"where DataDaEntregaRealizada >= '{DateTime.Now.AddDays(-30).ToString("yyyy/MM/dd")}' " +
                $"and  DataDaEntregaRealizada <= '{DateTime.Now.ToString("yyyy/MM/dd")}'" +
                "GROUP BY YEAR(DataDaEntregaRealizada), MONTH(DataDaEntregaRealizada), DAY(DataDaEntregaRealizada) ";

            using var connection = new MySqlConnection(connectionString);

            if (connection.State == ConnectionState.Closed)
                connection.Open();

            var command = new MySqlCommand(query, connection) { CommandType = CommandType.Text };

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var random = new Random();
                    var color = String.Format("#{0:X6}", random.Next(0x1000000));

                    var retornoAdd = new EntregaPorDia
                    {
                        value = $"{reader["Quantidade"]}",
                        title = $"Dia {Convert.ToDateTime(reader["DataDaEntregaRealizada"]).ToString("dd/MM/yyyy")}",
                        color = color
                    };

                    retorno.Add(retornoAdd);
                }
            }
            connection.Close();

            return retorno;

        }


    }
}
