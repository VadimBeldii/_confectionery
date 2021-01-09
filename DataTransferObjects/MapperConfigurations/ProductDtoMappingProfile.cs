using AutoMapper;
using Confectionery.BLL.DTOs;
using Confectionery.DAL.Entities;

namespace Confectionery.BLL.Mapping
{
    public class ProductDTOMappingProfile : Profile
    {
        public ProductDTOMappingProfile()
        {
            CreateMap<ProductDTO, Product>();
            CreateMap<Product, ProductDTO>();
        }
    }
}
