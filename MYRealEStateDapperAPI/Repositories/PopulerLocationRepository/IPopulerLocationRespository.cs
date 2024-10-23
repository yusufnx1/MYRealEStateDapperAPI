using MYRealEStateDapperAPI.Dtos.PopulerLocationDtos;

namespace MYRealEStateDapperAPI.Repositories.PopulerLocationRepository
{
    public interface IPopulerLocationRespository
    {
        Task<List<ResultPopulerLocationDto>> GetAllPopulerLocationAsync();
        void AddPopulerLocationAsync(CreatePopulerLocationDto populerLocation);
        void RemovePopulerLocationAsync(int id);
        void UpdatePopulerLocationAsync(UpdatePopulerLocationDto populerLocationDto);
        Task<ResultPopulerLocationDto> GetByIdPopulerLocation(int id);
    }
}
