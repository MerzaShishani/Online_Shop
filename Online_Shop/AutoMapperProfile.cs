using AutoMapper;
using Online_Shop.Dtos.Product;
using Online_Shop.Dtos.User;
using Online_Shop.Models;

namespace Online_Shop
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {
            CreateMap<AddProductDto, Product>();
            CreateMap<Product, GetProductDto>();
            CreateMap<UpdateProductDto,Product>();
            CreateMap<UserRegistrationDto,User>();
        }
    }
}
