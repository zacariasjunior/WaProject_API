using System;
using System.Collections.Generic;
using WaProject_API.Infra.Repository.Interface;

namespace WaProject_API.Service
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public void Add(TEntity obj)
        {
            _repository.Add(obj);
        }

        public TEntity GetById(Guid id)
        {
            return _repository.GetById(id);
        }


        public TEntity GetByStrId(string id)
        {
            return _repository.GetByStrId(id);
        }

        public TEntity GetByintId(int id)
        {
            return _repository.GetByintId(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            _repository.Remove(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}