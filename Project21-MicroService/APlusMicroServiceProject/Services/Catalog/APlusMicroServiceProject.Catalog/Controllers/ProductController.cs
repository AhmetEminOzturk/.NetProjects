using APlusMicroServiceProject.Catalog.Dtos;
using APlusMicroServiceProject.Catalog.Services.Abstract;
using APlusMicroServiceProject.Shared.ControllerBases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace APlusMicroServiceProject.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : CustomBaseController
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _productService.GetAllAsync();
            return CreateActionResultInstance(products);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByID(string id)
        {
            var product = await _productService.GetByIdAsync(id);
            return CreateActionResultInstance(product);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(string id)
        {
            var products = await _productService.DeleteAsync(id);
            return CreateActionResultInstance(products);
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(CreateProductDto createProductDto)
        {
            var products = await _productService.CreateAsync(createProductDto);
            return CreateActionResultInstance(products);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
        {
            var products = await _productService.UpdateAsync(updateProductDto);
            return CreateActionResultInstance(products);
        }
    }
}
