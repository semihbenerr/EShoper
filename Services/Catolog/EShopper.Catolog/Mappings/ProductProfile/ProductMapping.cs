using AutoMapper;
using EShopper.Catolog.Dtos.ProductDtos;
using EShopper.Catolog.Entities;

namespace EShopper.Catolog.Mappings.ProductProfile
{
    public class ProductMapping : Profile
    {
        public ProductMapping()
        {
            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, GetByIdProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
        }
    }
}
