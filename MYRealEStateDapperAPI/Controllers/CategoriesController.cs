using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MYRealEStateDapperAPI.Dtos.CategoryDtos;
using MYRealEStateDapperAPI.Repositories.CategoryRepository;

namespace MYRealEStateDapperAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            var value = await _categoryRepository.GetAllCategoryAsync();
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto categoryDto)
        {
            _categoryRepository.AddCategoryAsync(categoryDto);
            return Ok("kategori başarılı şekilde eklendi.");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveCategory(int id)
        {
            _categoryRepository.RemoveCategoryAsync(id);
            return Ok("kategori başarılı bir şekilde silindi.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategory)
        {
            _categoryRepository.UpdateCategoryAsync(updateCategory);
            return Ok("kategori başarıyla güncellendi.");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdCategory(int id)
        {
            var value = await _categoryRepository.GetByIdCategory(id);
            return Ok(value);
        }
    }
}
