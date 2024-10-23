using MYRealEStateDapperAPI.Dtos.ClientDtos;
using MYRealEStateDapperAPI.Dtos.TestimonialDtos;

namespace MYRealEStateDapperAPI.Repositories.TestimonialRepository
{
    public interface ITestimonialRepository
    {
        Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
        void AddTestimonialAsync(CreateTestimonialDto Testimonial);
        void RemoveTestimonialAsync(int id);
        void UpdateTestimonialAsync(UpdateTestimonialDto TestimonialDto);
        Task<ResultTestimonialDto> GetByIdTestimonial(int id);
    }
}
