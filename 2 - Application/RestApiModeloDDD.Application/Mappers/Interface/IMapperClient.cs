using RestApiModeloDDD.Domain.Entities;
using RestApiModeloDDD.Application.Dtos;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application.Mappers.Interface
{
    public interface IMapperClient
    {
        Client MapperDtoToEntity(ClientDto clientDto);
        IEnumerable<ClientDto> MapperListClientDto(IEnumerable<Client> clients);
        ClientDto MapperEntityToDto(Client client);
    }
}