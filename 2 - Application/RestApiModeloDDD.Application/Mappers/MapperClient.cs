using RestApiModeloDDD.Application.Mappers.Interface;
using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModeloDDD.Application.Mappers
{
    public class MapperClient : IMapperClient
    {
        IEnumerable<ClientDto> ClientsDtos = new List<ClientDto>();


        public Client MapperDtoToEntity(ClientDto clientDto)
        {
            Client client = new Client()
            {
                Id = clientDto.Id,
                FirstName = clientDto.FirstName,
                LastName = clientDto.LastName,
                Email =  clientDto.Email
            };

            return client;
        }
        public IEnumerable<ClientDto> MapperListClientDto(IEnumerable<Client> clients)
        {
            IEnumerable<ClientDto> dto = clients.Select(c => new ClientDto 
                {
                    Id = c.Id,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    Email = c.Email
                });

            return dto;
        }
        public ClientDto MapperEntityToDto(Client client)
        {
            ClientDto clientDto = new ClientDto()
            {
                Id = client.Id,
                FirstName = client.FirstName,
                LastName = client.LastName,
                Email = client.Email
            };

            return clientDto;
        }
    }
}