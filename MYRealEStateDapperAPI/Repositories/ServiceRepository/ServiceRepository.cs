using Dapper;
using MYRealEStateDapperAPI.Dtos.ServiceDtos;
using MYRealEStateDapperAPI.Models.DapperContext;
using System.Reflection.Metadata;

namespace MYRealEStateDapperAPI.Repositories.ServiceRepository
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly Context _context;

        public ServiceRepository(Context context)
        {
            _context = context;
        }

        public void AddServiceAsync(CreateServiceDto createServiceDto)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultServiceDto>> GetAllServiceAsync()
        {
            string query = "select * from Service";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultServiceDto>(query);
                return values.ToList();
            }
        }

        public Task<GetByIdServiceDto> GetService(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveServiceAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateServiceAsync(UpdateServiceDto updateService)
        {
            throw new NotImplementedException();
        }
    }
}
