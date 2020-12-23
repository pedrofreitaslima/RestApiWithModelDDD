using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Mappers.Interface;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using RestApiModeloDDD.Domain.Entities;
using System.Collections.Generic;


namespace RestApiModeloDDD.Application
{
    public class ApplicationServiceClient : IApplicationServiceClient
    {
        private readonly IServiceClient _ServiceClient;
        private readonly IMapperClient _MapperClient;

        public ApplicationServiceClient(IServiceClient serviceClient, IMapperClient mapperClient)
        {
            this._ServiceClient = serviceClient;
            this._MapperClient = mapperClient;
        }

        public void Add(ClientDto clientDto)
        {
            _ServiceClient.Add(_MapperClient.MapperDtoToEntity(clientDto));
        }
        public IEnumerable<ClientDto> GetAll()
        {
            return _MapperClient.MapperListClientDto(_ServiceClient.GetAll());
        }
        public ClientDto GetById(int Id)
        {
            return _MapperClient.MapperEntityToDto(_ServiceClient.GetById(Id));
        }
        public void Update(ClientDto clientDto)
        {
            _ServiceClient.Update(_MapperClient.MapperDtoToEntity(clientDto));
        }
        public void Remove(ClientDto clientDto)
        {
            _ServiceClient.Remove(_MapperClient.MapperDtoToEntity(clientDto));
        }

    }
}