using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using RestApiModeloDDD.Domain.Entities;
using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;

namespace RestApiModeloDDD.Domain.Services
{
    public class ServiceClient : ServiceBase<Client>, IServiceClient
    {
        private readonly IRepositoryClient _RepositoryClient;
        public ServiceClient(IRepositoryClient repositoryClient) : base(repositoryClient)
        {
            this._RepositoryClient = repositoryClient;
        }
    }
}