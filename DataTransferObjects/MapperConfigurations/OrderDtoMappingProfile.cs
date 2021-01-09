using AutoMapper;
using Confectionery.BLL.DTOs;
using Confectionery.DAL.Entities;

namespace Confectionery.BLL.Mapping
{
    public class OrderDTOMappingProfile : Profile
    {
        public OrderDTOMappingProfile()
        {
            CreateMap<OrderDTO, Order>();
            CreateMap<Order, OrderDTO>();
        }
    }
}
