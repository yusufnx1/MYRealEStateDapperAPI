using Dapper;
using Microsoft.AspNetCore.Components;
using MYRealEStateDapperAPI.Dtos.WhoWeAreDetailDtos;
using MYRealEStateDapperAPI.Dtos.WhoWeAreDtos;
using MYRealEStateDapperAPI.Models.DapperContext;
using System.Dynamic;

namespace MYRealEStateDapperAPI.Repositories.WhoWeAreRepository
{
    public class WhoWeAreDetailRepository : IWhoWeAreDetailRepository
    {
        private readonly Context _context;

        public WhoWeAreDetailRepository(Context context)
        {
            _context = context;
        }

        public async void AddWhoWeAreDetailAsync(CreateWhoWeAreDetailDto whoWeAreDetail)
        {
            string query = "insert into WhoWeAreDetail (Title, SubTitle, Description1, Description2)" +
                "values (@title, @subTitle, @description1, @description2)";
            var parameters = new DynamicParameters();
            parameters.Add("@title", whoWeAreDetail.Title);
            parameters.Add("@subTitle", whoWeAreDetail.SubTitle);
            parameters.Add("@description1", whoWeAreDetail.Description1);
            parameters.Add("@description2", whoWeAreDetail.Description2);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }

        }

        public async Task<List<ResultWhoWeAreDetailDto>> GetAllWhoWeAreDetailAsync()
        {
            string query = "select * from WhoWeAreDetail";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultWhoWeAreDetailDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIdWhoWeAreDetailDto> GetByIdWhoWeAreDetail(int id)
        {
            string query = "select * from WhoWeAreDetail where WhoWeAreDetailID=@whoWeAreDetailID";
            var parameters = new DynamicParameters();
            parameters.Add("@whoWeAreDetailID", id);
            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryFirstAsync<GetByIdWhoWeAreDetailDto>(query, parameters);
                return value;
            }

        }

        public async void RemoveWhoWeAreDetailAsync(int id)
        {
            string query = "Delete from WhoWeAreDetail where WhoWeAreDetailID=@whoWeAreDetailID";
            var parameters = new DynamicParameters();
            parameters.Add("@whoWeAreDetailID", id);
            using (var connections = _context.CreateConnection())
            {
                await connections.ExecuteAsync(query, parameters);
            }
        }

        public async void UpdateWhoWeAreDetailAsync(UpdateWhoWeAreDetailDto whoWeAreDetailDto)
        {
            string query = "Update WhoWeAreDetail set Title= @title, SubTitle= @subTitle," +
                " Description1= @description1, Description2= @description2 where WhoWeAreDetailId= @whoWeAreDetailID";
            var parameters = new DynamicParameters();
            parameters.Add("@title",whoWeAreDetailDto.Title);
            parameters.Add("@subTitle",whoWeAreDetailDto.SubTitle);
            parameters.Add("@description1",whoWeAreDetailDto.Description1);
            parameters.Add("@description2",whoWeAreDetailDto.Description2);
            parameters.Add("@whoWeAreDetailID", whoWeAreDetailDto.WhoWeAreDetailId);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
