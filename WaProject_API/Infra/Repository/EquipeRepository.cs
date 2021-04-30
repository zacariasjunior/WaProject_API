using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaProject_API.Infra.Context;
using WaProject_API.Infra.Repository.Interface;
using WaProject_API.ValueObjects;

namespace WaProject_API.Infra.Repository
{
    public class EquipeRepository : RepositoryBase<Equipe>, IEquipeRepository
    {
        private DataContext _dataContext;

        public EquipeRepository(DataContext dataContext) : base(dataContext)
        {
            this._dataContext = dataContext;
        }
    }
}