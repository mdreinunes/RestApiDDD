using RestApiDDD.Application.Dtos;
using RestApiDDD.Domain.Entitys;
using System.Collections.Generic;

namespace RestApiDDD.Application.Interfaces.Mappers 
{ 
    public interface IMapperCliente
    {
        Cliente MapperDtoToEntity(ClienteDto clienteDto);
        IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes);

        ClienteDto MapperEntityToDto(Cliente cliente);
    }
}
