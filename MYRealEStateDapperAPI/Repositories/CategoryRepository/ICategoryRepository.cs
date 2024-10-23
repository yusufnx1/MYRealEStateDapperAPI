using MYRealEStateDapperAPI.Dtos.CategoryDtos;

namespace MYRealEStateDapperAPI.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        void AddCategoryAsync(CreateCategoryDto category);
        void RemoveCategoryAsync(int id);
        void UpdateCategoryAsync(UpdateCategoryDto categoryDto);
        Task<ResultCategoryDto> GetByIdCategory(int id );
    }
}
