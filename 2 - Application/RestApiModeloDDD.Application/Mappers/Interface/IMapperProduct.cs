using RestApiModeloDDD.Domain.Entities;
using RestApiModeloDDD.Application.Dtos;
using System.Collections.Generic;


namespace RestApiModeloDDD.Application.Mappers.Interface
{
    public interface IMapperProduct
    {
        Product MapperDtoToEntity(ProductDto productDto);
        IEnumerable<ProductDto> MapperListProductDto(IEnumerable<Product> products);
        ProductDto MapperEntityToDto(Product product);
    }
}