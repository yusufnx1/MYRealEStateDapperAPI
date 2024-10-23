using MYRealEStateDapperAPI.Dtos.WhoWeAreDetailDtos;
using MYRealEStateDapperAPI.Dtos.WhoWeAreDtos;

namespace MYRealEStateDapperAPI.Repositories.WhoWeAreRepository
{
    public interface IWhoWeAreDetailRepository
    {
        Task<List<ResultWhoWeAreDetailDto>> GetAllWhoWeAreDetailAsync();
        void AddWhoWeAreDetailAsync(CreateWhoWeAreDetailDto whoWeAreDetail);
        void RemoveWhoWeAreDetailAsync(int id);
        void UpdateWhoWeAreDetailAsync(UpdateWhoWeAreDetailDto whoWeAreDetailDto);
        Task<GetByIdWhoWeAreDetailDto> GetByIdWhoWeAreDetail(int id);
    }
}
