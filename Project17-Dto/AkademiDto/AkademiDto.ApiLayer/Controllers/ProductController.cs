using AkademiDto.BusinessLayer.Abstract;
using AkademiDto.DtoLayer.ProductDto;
using AkademiDto.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkademiDto.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IActionResult ProducutList() 
        {
            var values = _productService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddProduct(CreateProductDto createProductDto)
        {
            Product product = new Product()
            {
                ProductName= createProductDto.ProductName,
                ProductPrice = createProductDto.ProductPrice,
                ProductStock = createProductDto.ProductStock,
                CategoryID= createProductDto.CategoryID,
            };
            _productService.TInsert(product);
            return Ok();
        }
    }
}
