using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModeloDDD.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {

        private readonly IRepositoryBase<TEntity> _Repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            this._Repository = repository;
        }

        public void Add(TEntity obj)
        {
            _Repository.Add(obj);
        }
        public void Remove(TEntity obj)
        {
            _Repository.Remove(obj);
        }
        public void Update(TEntity obj)
        {
            _Repository.Update(obj);
        }
        public IEnumerable<TEntity> GetAll()
        {
            return _Repository.GetAll();
        }
        public TEntity GetById(int Id)
        {
            return _Repository.GetById(Id);
        }
    }
}