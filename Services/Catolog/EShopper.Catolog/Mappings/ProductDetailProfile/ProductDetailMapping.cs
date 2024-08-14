using AutoMapper;
using EShopper.Catolog.Dtos.ProductDetailDtos;
using EShopper.Catolog.Entities;

namespace EShopper.Catolog.Mappings.ProductDetailProfile
{
    public class ProductDetailMapping : Profile
    {
        public ProductDetailMapping()
        {
            CreateMap<ProductDetail, ResultProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, CreateProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, GetByIdProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, UpdateProductDetailDto>().ReverseMap();
        }
    }
}
