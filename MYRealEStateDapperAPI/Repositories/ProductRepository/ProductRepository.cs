using Dapper;
using MYRealEStateDapperAPI.Dtos.ProductDtos;
using MYRealEStateDapperAPI.Models.DapperContext;

namespace MYRealEStateDapperAPI.Repositories.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;

        public ProductRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultProductDto>> GetAllProductList()
        {
            string query = "select * from Product";
            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryAsync<ResultProductDto>(query);
                return value.ToList();
            }
        }

        public async Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryList()
        {
            string query = "select ProductId, Title, Price, Address, CoverImage, Type, City,Disctirct, CategoryName" +
                " from Product inner join Category on " +
                "Product.ProductCategory = Category.CategoryId";
            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryAsync<ResultProductWithCategoryDto>(query);
                return value.ToList();
            }
        }
    }
}
