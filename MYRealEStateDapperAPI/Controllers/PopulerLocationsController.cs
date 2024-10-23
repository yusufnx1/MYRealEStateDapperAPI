using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MYRealEStateDapperAPI.Repositories.PopulerLocationRepository;

namespace MYRealEStateDapperAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopulerLocationsController : ControllerBase
    {
        private readonly IPopulerLocationRespository _populerRepository;

        public PopulerLocationsController(IPopulerLocationRespository populerRepository)
        {
            _populerRepository = populerRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetPopulerLocationList()
        {
            var value = await _populerRepository.GetAllPopulerLocationAsync();
            return Ok(value);
        }
    }
}
