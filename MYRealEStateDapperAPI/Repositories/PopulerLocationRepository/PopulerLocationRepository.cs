using Dapper;
using MYRealEStateDapperAPI.Dtos.PopulerLocationDtos;
using MYRealEStateDapperAPI.Models.DapperContext;

namespace MYRealEStateDapperAPI.Repositories.PopulerLocationRepository
{
    public class PopulerLocationRepository : IPopulerLocationRespository
    {
        private readonly Context _context;

        public PopulerLocationRepository(Context context)
        {
            _context = context;
        }

        public void AddPopulerLocationAsync(CreatePopulerLocationDto populerLocation)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultPopulerLocationDto>> GetAllPopulerLocationAsync()
        {
            string query = "select * from PopulerLocation";
            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryAsync<ResultPopulerLocationDto>(query);
                return value.ToList();
            }
        }

        public Task<ResultPopulerLocationDto> GetByIdPopulerLocation(int id)
        {
            throw new NotImplementedException();
        }

        public void RemovePopulerLocationAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdatePopulerLocationAsync(UpdatePopulerLocationDto populerLocationDto)
        {
            throw new NotImplementedException();
        }
    }
}
