using MYRealEStateDapperAPI.Dtos.BottomGridDtos;

namespace MYRealEStateDapperAPI.Repositories.BottomGridRepository
{
    public interface IBottomGridRepository
    {
        Task<List<ResultBottomGridDto>> GetAllBottomGridAsync();
        void AddBottomGridAsync(CreateBottomGridDto bottomGrid);
        void RemoveBottomGridAsync(int id);
        void UpdateBottomGridAsync(UpdateBottomGridDto bottomGridDto);
        Task<ResultBottomGridDto> GetByIdBottomGrid(int id);
    }
}
