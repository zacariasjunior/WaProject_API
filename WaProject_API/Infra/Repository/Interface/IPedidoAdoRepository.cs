using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaProject_API.Dto;
using WaProject_API.Models;

namespace WaProject_API.Infra.Repository.Interface
{
   public interface IPedidoAdoRepository 
    {
        List<Pedido> ListarTodosPedidosComEquipeProdutos(int pageNum, int pageSize);
        List<EntregaPorDia> ListarEntregaPorDiaPeriodo30Dias();
        int TotalDePedidos();



    }
}
