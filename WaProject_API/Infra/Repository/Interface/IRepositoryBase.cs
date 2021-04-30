using System;
using System.Collections.Generic;

namespace WaProject_API.Infra.Repository.Interface
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(Guid id);
        TEntity GetByStrId(string id);
        TEntity GetByintId(int id);
        IEnumerable<TEntity> GetAll();
        List<TEntity> GetListAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
    }
}