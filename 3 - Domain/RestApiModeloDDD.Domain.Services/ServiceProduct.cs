using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using RestApiModeloDDD.Domain.Entities;
using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;

namespace RestApiModeloDDD.Domain.Services
{
    public class ServiceProduct : ServiceBase<Product>, IServiceProduct
    {
         private readonly IRepositoryProduct _RepositoryProduct;

        public ServiceProduct(IRepositoryProduct repositoryProduct) : base(repositoryProduct)
        {
            this._RepositoryProduct = repositoryProduct;
        }
    }
}