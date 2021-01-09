using AutoMapper;
using Confectionery.BLL.DTOs;
using Confectionery.DAL.Entities;

namespace Confectionery.BLL.Mapping
{
    public class OrderItemDTOMappingProfile : Profile
    {
        public OrderItemDTOMappingProfile()
        {
            CreateMap<OrderItemDTO, OrderItem>();
            CreateMap<OrderItem, OrderItemDTO>();
        }
    }
}
