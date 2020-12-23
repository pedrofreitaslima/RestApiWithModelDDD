using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace RestApiModeloDDD.Infrastructure.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly SqlContext _SqlContext;

        public RepositoryBase(SqlContext sqlContext)
        {
            this._SqlContext = sqlContext;
        }

        public void Add(TEntity obj)
        {
            try
            {
                _SqlContext.Set<TEntity>().Add(obj);
                _SqlContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Update(TEntity obj)
        {
            try
            {
                _SqlContext.Entry(obj).State = EntityState.Modified;
                _SqlContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Remove(TEntity obj)
        {
            try
            {
                _SqlContext.Set<TEntity>().Remove(obj);
                _SqlContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<TEntity> GetAll()
        {
            return _SqlContext.Set<TEntity>().ToList();
        }
        public TEntity GetById(int Id)
        {
            return _SqlContext.Set<TEntity>().Find(Id);
        }

    }
}