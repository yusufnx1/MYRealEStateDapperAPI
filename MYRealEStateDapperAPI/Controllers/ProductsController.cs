using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MYRealEStateDapperAPI.Repositories.ProductRepository;

namespace MYRealEStateDapperAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProduct()
        {
            var value = await _productRepository.GetAllProductList();
            return Ok(value);
        }
        [HttpGet("GetAllProductWithCategoryList")]
        public async Task<IActionResult> GetAllProductWithCategoryList()
        {
            var value = await _productRepository.GetAllProductWithCategoryList();
            return Ok(value);
        }
    }
}
