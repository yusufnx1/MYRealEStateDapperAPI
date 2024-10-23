using Dapper;
using MYRealEStateDapperAPI.Dtos.BottomGridDtos;
using MYRealEStateDapperAPI.Models.DapperContext;

namespace MYRealEStateDapperAPI.Repositories.BottomGridRepository
{
    public class BottomGridRepository : IBottomGridRepository
    {
        private readonly Context _context;

        public BottomGridRepository(Context context)
        {
            _context = context;
        }

        public void AddBottomGridAsync(CreateBottomGridDto bottomGrid)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultBottomGridDto>> GetAllBottomGridAsync()
        {
            string query = "select * from BottomGrid";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultBottomGridDto>(query);
                return values.ToList();
            }
        }

        public Task<ResultBottomGridDto> GetByIdBottomGrid(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveBottomGridAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateBottomGridAsync(UpdateBottomGridDto bottomGridDto)
        {
            throw new NotImplementedException();
        }
    }
}
