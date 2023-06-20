using APlusMicroServiceProject.Catalog.Dtos;
using APlusMicroServiceProject.Shared.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APlusMicroServiceProject.Catalog.Services.Abstract
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
