using RestApiModeloDDD.Domain.Entities;
using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;

namespace RestApiModeloDDD.Infrastructure.Data.Repositories
{
    public class RepositoryProduct : RepositoryBase<Product>, IRepositoryProduct
    {
        private readonly SqlContext _SqlContext;

        public RepositoryProduct(SqlContext sqlContext) : base(sqlContext)
        {
            this._SqlContext = sqlContext;
        }
    }
}