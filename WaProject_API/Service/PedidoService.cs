using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaProject_API.Dto;
using WaProject_API.Infra.Repository.Interface;
using WaProject_API.Models;
using WaProject_API.Service.Interface;
using WaProject_API.ValueObjects;

namespace WaProject_API.Service
{
    public class PedidoService : IPedidoService
    {

        private readonly IPedidoRepository _pedidoRepository;
        private readonly IEquipeRepository _equipeRepository;
        private readonly IProdutoRepository _produtoRepository;
        private readonly IPedidoAdoRepository _pedidoAdoRepository;

        public PedidoService(IPedidoRepository pedidoRepository, IEquipeRepository equipeRepository, IProdutoRepository produtoRepository, IPedidoAdoRepository pedidoAdoRepository)
        {
            _pedidoRepository = pedidoRepository;
            _equipeRepository = equipeRepository;
            _produtoRepository = produtoRepository;
            _pedidoAdoRepository = pedidoAdoRepository;
        }

        /// <summary>
        /// Lista Todos os Pedidos Com Equipe e Produtos
        /// Utilizado ADO para ganho do desnpenho das consultas
        /// </summary>
        /// <param name="pageNum"></param>
        /// <param name="pageSize"></param>
        /// <returns>List<Pedido></returns>
        public List<Pedido> ListarTodosPedidosComEquipeProdutos(int pageNum, int pageSize)
        {
            var retorno = new List<Pedido>();

            var retornoProdutos = new List<Pedido>();

            var pedidos = _pedidoRepository.GetListAll();
            var equipes = _equipeRepository.GetListAll();
            var produtos = _produtoRepository.GetListAll();

            foreach (var pedido in pedidos)
            {
                pedido.Equipe = equipes.FirstOrDefault(x => x.PedidoId == pedido.Id);

                pedido.Produtos = produtos.Where(x => x.PedidoId == pedido.Id);

                retornoProdutos.Add(pedido);
            }

            retorno = retornoProdutos.Skip(pageSize * (pageNum - 1))
                .Take(pageSize).ToList();

            return retorno;

        }

        /// <summary>
        /// Lista Todos os Pedidos Com Equipe e Produtos
        /// Utilizado ADO para ganho do desnpenho das consultas
        /// </summary>
        /// <param name="pageNum"></param>
        /// <param name="pageSize"></param>
        /// <returns>List<Pedido></returns>
        public List<Pedido> ListarTodosPedidosComEquipeProdutosAdo(int pageNum, int pageSize)
        {
            var retorno = _pedidoAdoRepository.ListarTodosPedidosComEquipeProdutos(pageNum, pageSize);

            return retorno;
        }

        /// <summary>
        /// Lista a quantidade de entregas por dia do ultimos 30 dias
        /// </summary>
        /// <returns>List<EntregaPorDia></returns>
        public List<EntregaPorDia> ListarEntregaPorDiaPeriodo30Dias()
        {
            var retorno = _pedidoAdoRepository.ListarEntregaPorDiaPeriodo30Dias();

            return retorno;
        }

        /// <summary>
        /// Adiciona pedidos aleatorio para teste
        /// </summary>
        public void AddPedidos()
        {

            var ultimoPedidos = _pedidoRepository.GetListAll().OrderByDescending(x => x.Id).ToList()[0];

            var pedidos = new List<Pedido>();

            var rng = new Random();

            var idDoPedido = ultimoPedidos.Id;

            for (int i = 0; i < 80; i++)
            {

                var data = DateTime.Now.AddDays(rng.Next(-20, 1));

                var produtos = new List<Produto>();

                for (int i2 = 0; i2 < rng.Next(2, 4); i2++)
                {

                    var produtoAdd = new Produto
                    {
                        PedidoId = idDoPedido +1,
                        Nome = $"Tv LED Cod - {rng.Next(40, 50)}",
                        Descricao = $"Tv LED Cod - {rng.Next(2000, 9000)} Samsung",
                        Valor = Convert.ToDecimal(rng.Next(1220, 2245))
                    };

                    produtos.Add(produtoAdd);
                }


                var equipeAdd = new Equipe
                {
                    PedidoId = idDoPedido + 1,
                    Nome = $"Equipe Setor - {rng.Next(40, 50)}",
                    Descricao = $"Equipe {rng.Next(2000, 9000)} atendimento especial",
                    PlacaDoVeiculo = $"ABC-{rng.Next(2000, 9000)}"
                };

                var pedidoAdd = new Pedido
                {
                    DataDeCriacao = data,
                    DataDaEntregaRealizada = data.AddDays(2),
                    EnderecoEntregaRealizada = $"Rua {rng.Next(1, 20)}, + Numero {rng.Next(50, 200)} Sao Paulo",
                    Equipe = equipeAdd,
                    Produtos = produtos
                };
                _pedidoRepository.Add(pedidoAdd);






                idDoPedido++;
            }
        }


        public int TotalDePedidos()
        {
            return _pedidoAdoRepository.TotalDePedidos();
        }

    }
}
