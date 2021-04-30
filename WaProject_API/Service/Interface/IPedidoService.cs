using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaProject_API.Dto;
using WaProject_API.Models;

namespace WaProject_API.Service.Interface
{
   public interface IPedidoService
    {
        List<Pedido> ListarTodosPedidosComEquipeProdutos(int pageNum, int pageSize);
        List<Pedido> ListarTodosPedidosComEquipeProdutosAdo(int pageNum, int pageSize);
        List<EntregaPorDia> ListarEntregaPorDiaPeriodo30Dias();
        void AddPedidos();
        int TotalDePedidos();
    }
}
