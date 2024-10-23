using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MYRealEStateDapperAPI.Repositories.TestimonialRepository;

namespace MYRealEStateDapperAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialRepository _testimonialRepository;

        public TestimonialController(ITestimonialRepository testimonialRepository)
        {
            _testimonialRepository = testimonialRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetTestimonialList()
        {
            var value = await _testimonialRepository.GetAllTestimonialAsync();
            return Ok(value);
        }
    }
}
