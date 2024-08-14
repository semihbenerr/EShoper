using AutoMapper;
using EShopper.Catolog.Dtos.ProductImageDtos;
using EShopper.Catolog.Entities;

namespace EShopper.Catolog.Mappings.ProductImageProfile
{
    public class ProductImageMapping : Profile
    {
        public ProductImageMapping()
        {
            CreateMap<ProductImage, ResultProductImageDto>().ReverseMap();
            CreateMap<ProductImage, CreateProductImageDto>().ReverseMap();
            CreateMap<ProductImage, GetByIdProductImageDto>().ReverseMap();
            CreateMap<ProductImage, UpdateProductImageDto>().ReverseMap();
        }
    }
}
