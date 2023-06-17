using AcademyPlusMicroServiceProject.Catalog.Dtos;
using AcademyPlusMicroServiceProject.Shared.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AcademyPlusMicroServiceProject.Catalog.Services.Abstract
{
    public interface ICategoryService
    {
        Task<Response<List<CategoryDto>>> GetAllAsync();
        Task<Response<CategoryDto>> CreateAsync(CreateCategoryDto createCategoryDto);
        Task<Response<CategoryDto>> GetByIdAsync(string id);
        Task<Response<NoContent>> UpdateAsync(UpdateCategoryDto updateCategoryDto);
        Task<Response<NoContent>> DeleteAsync(string id);
    }
}
