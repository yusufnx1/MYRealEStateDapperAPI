using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MYRealEStateDapperAPI.Repositories.BottomGridRepository;

namespace MYRealEStateDapperAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BottomGridController : ControllerBase
    {
        private readonly IBottomGridRepository _bottomGridRepository;

        public BottomGridController(IBottomGridRepository bottomGridRepository)
        {
            _bottomGridRepository = bottomGridRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetBottomGrid()
        {
            var value = await _bottomGridRepository.GetAllBottomGridAsync();
            return Ok(value);
        }
    }
}
