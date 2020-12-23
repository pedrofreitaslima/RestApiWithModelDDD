using System;
using System.Collections.Generic;

namespace RestApiModeloDDD.Domain.Core.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        void Remove(TEntity obj);
        void Update(TEntity obj);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int Id);         
    }
}