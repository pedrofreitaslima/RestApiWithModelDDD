using RestApiModeloDDD.Domain.Entities;
using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;

namespace RestApiModeloDDD.Infrastructure.Data.Repositories
{
    public class RepositoryClient : RepositoryBase<Client>, IRepositoryClient
    {
        private readonly SqlContext _SqlContext;

        public RepositoryClient(SqlContext sqlContext) : base(sqlContext)
        {
            this._SqlContext = sqlContext;
        }
    }
}