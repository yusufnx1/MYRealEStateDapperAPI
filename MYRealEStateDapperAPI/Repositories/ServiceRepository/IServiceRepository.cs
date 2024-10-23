using MYRealEStateDapperAPI.Dtos.ServiceDtos;

namespace MYRealEStateDapperAPI.Repositories.ServiceRepository
{
    public interface IServiceRepository
    {
        Task<List<ResultServiceDto>> GetAllServiceAsync();
        void AddServiceAsync(CreateServiceDto createServiceDto);
        void RemoveServiceAsync(int id);
        void UpdateServiceAsync(UpdateServiceDto updateService);
        Task<GetByIdServiceDto> GetService(int id);
    }
}
