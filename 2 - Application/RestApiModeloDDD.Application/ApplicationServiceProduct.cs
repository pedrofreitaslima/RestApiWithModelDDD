using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Mappers.Interface;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using RestApiModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application
{
    public class ApplicationServiceProduct : IApplicationServiceProduct
    {
        private readonly IServiceProduct _ServiceProduct;
        private readonly IMapperProduct _MapperProduct;

        public ApplicationServiceProduct(IServiceProduct serviceProduct, IMapperProduct mapperProduct)
        {
            this._ServiceProduct = serviceProduct;
            this._MapperProduct = mapperProduct;
        }

        public void Add(ProductDto productDto)
        {
            _ServiceProduct.Add(_MapperProduct.MapperDtoToEntity(productDto));
        }
        public IEnumerable<ProductDto> GetAll()
        {
            return _MapperProduct.MapperListProductDto(_ServiceProduct.GetAll());
        }
        public ProductDto GetById(int Id)
        {
            return _MapperProduct.MapperEntityToDto(_ServiceProduct.GetById(Id));
        }
        public void Update(ProductDto productDto)
        {
            _ServiceProduct.Update(_MapperProduct.MapperDtoToEntity(productDto));
        }
        public void Remove(ProductDto productDto)
        {
            _ServiceProduct.Remove(_MapperProduct.MapperDtoToEntity(productDto));
        }

    }
}