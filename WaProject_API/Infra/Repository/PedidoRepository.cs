using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaProject_API.Infra.Context;
using WaProject_API.Infra.Repository.Interface;
using WaProject_API.Models;

namespace WaProject_API.Infra.Repository
{
    public class PedidoRepository :  RepositoryBase<Pedido>, IPedidoRepository 
    {
        private DataContext _dataContext;

        public PedidoRepository(DataContext dataContext) : base(dataContext)
        {
            this._dataContext = dataContext;
        }
    }
}
