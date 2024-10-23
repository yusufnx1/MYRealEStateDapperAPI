using MYRealEStateDapperAPI.Dtos.ProductDtos;

namespace MYRealEStateDapperAPI.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductList();
        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryList();
    }
}
