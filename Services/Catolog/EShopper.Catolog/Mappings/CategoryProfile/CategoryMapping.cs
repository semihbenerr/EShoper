using AutoMapper;
using EShopper.Catolog.Dtos.CategoryDtos;
using EShopper.Catolog.Entities;

namespace EShopper.Catolog.Mappings.CategoryProfile
{
    public class CategoryMapping: Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, GetByIdCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
        }
    }
}
