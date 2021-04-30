using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaProject_API.Infra.Context;
using WaProject_API.Infra.Repository.Interface;
using WaProject_API.ValueObjects;

namespace WaProject_API.Infra.Repository
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        private DataContext _dataContext;

        public ProdutoRepository(DataContext dataContext) : base(dataContext)
        {
            this._dataContext = dataContext;
        }
    }
}