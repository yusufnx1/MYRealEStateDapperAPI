using Dapper;
using MYRealEStateDapperAPI.Dtos.ClientDtos;
using MYRealEStateDapperAPI.Dtos.TestimonialDtos;
using MYRealEStateDapperAPI.Models.DapperContext;

namespace MYRealEStateDapperAPI.Repositories.TestimonialRepository
{
    public class TestimonialRepository : ITestimonialRepository
    {
        private readonly Context _context;

        public TestimonialRepository(Context context)
        {
            _context = context;
        }

        public void AddTestimonialAsync(CreateTestimonialDto Testimonial)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultTestimonialDto>> GetAllTestimonialAsync()
        {
            string query = "select * from Testimonial";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultTestimonialDto>(query);
                return values.ToList(); 
            }
        }

        public Task<ResultTestimonialDto> GetByIdTestimonial(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveTestimonialAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateTestimonialAsync(UpdateTestimonialDto TestimonialDto)
        {
            throw new NotImplementedException();
        }
    }
}
