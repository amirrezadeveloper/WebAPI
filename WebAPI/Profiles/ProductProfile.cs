using AutoMapper;
using WebAPI.Dtos;
using WebAPI.Models;

namespace WebAPI.Profiles
{
    public class ProductProfile: Profile
    {
        public ProductProfile()
        {
            //Source,Dest
            CreateMap<AddProductDto, Product>();
            CreateMap<Product, ProductDto>();
        }
    }
}
