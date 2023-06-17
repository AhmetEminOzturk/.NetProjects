using AcademyPlusMicroServiceProject.Catalog.Dtos;
using AcademyPlusMicroServiceProject.Catalog.Models;
using AutoMapper;

namespace AcademyPlusMicroServiceProject.Catalog.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Category,CategoryDto>().ReverseMap();
            CreateMap<Category,UpdateCategoryDto>().ReverseMap();
            CreateMap<Category,CreateCategoryDto>().ReverseMap();
            
            CreateMap<Product,ProductDto>().ReverseMap();
            CreateMap<Product,UpdateProductDto>().ReverseMap();
            CreateMap<Product,CreateProductDto>().ReverseMap();
        }
    }
}
