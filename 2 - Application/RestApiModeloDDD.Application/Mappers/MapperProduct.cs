using RestApiModeloDDD.Application.Mappers.Interface;
using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModeloDDD.Application.Mappers
{
    public class MapperProduct : IMapperProduct
    {
         IEnumerable<ProductDto> ProductsDtos = new List<ProductDto>();


        public Product MapperDtoToEntity(ProductDto productDto)
        {
            Product product = new Product()
            {
                Id = productDto.Id,
                Title = productDto.Title,
                Price = productDto.Price
            };

            return product;
        }
        public IEnumerable<ProductDto> MapperListProductDto(IEnumerable<Product> products)
        {
            IEnumerable<ProductDto> dto = products.Select(p => new ProductDto()
            {
                Id = p.Id,
                Title = p.Title,
                Price = p.Price
            });

            return dto;
        }
        public ProductDto MapperEntityToDto(Product product)
        {
            ProductDto dto = new ProductDto()
            {
                Id = product.Id,
                Title = product.Title,
                Price = product.Price
            };

            return dto;
        }
    }
}