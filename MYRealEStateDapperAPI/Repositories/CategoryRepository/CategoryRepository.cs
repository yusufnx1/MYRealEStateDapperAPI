using MYRealEStateDapperAPI.Dtos.CategoryDtos;
using MYRealEStateDapperAPI.Models.DapperContext;
using Dapper;

namespace MYRealEStateDapperAPI.Repositories.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;

        public CategoryRepository(Context context)
        {
            _context = context;
        }

        public async void AddCategoryAsync(CreateCategoryDto category)
        {
            string quert = "insert into Category (CategoryName,CategoryStatus) " +
                "values (@categoryName,@CategoryStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName", category.CategoryName);
            parameters.Add("@categoryStatus", true);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(quert, parameters);
            }
        }

        public async Task<List<ResultCategoryDto>> GetAllCategoryAsync()
        {
            string query = "Select * From Category";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultCategoryDto>(query);
                return values.ToList();
            }
        }

        public async Task<ResultCategoryDto> GetByIdCategory(int id)
        {
            string query = "select * from Category where CategoryID=@categoryID";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryID", id);
            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryFirstOrDefaultAsync<ResultCategoryDto>(query, parameters);
                return value;
            }
        }

        public async void RemoveCategoryAsync(int id)
        {
            string query = "delete from Category where CategoryId=@categoryID";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void UpdateCategoryAsync(UpdateCategoryDto categoryDto)
        {
            string query = "Update Category set CategoryName=@categoryName, CategoryStatus=@categoryStatus where CategoryID=@categoryID";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName", categoryDto.CategoryName);
            parameters.Add("@categoryStatus", categoryDto.CategoryStatus);
            parameters.Add("@categoryID", categoryDto.CategoryId);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
