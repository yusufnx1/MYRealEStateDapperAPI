using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MYRealEStateDapperAPI.Dtos.WhoWeAreDetailDtos;
using MYRealEStateDapperAPI.Repositories.WhoWeAreRepository;

namespace MYRealEStateDapperAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhoWeAreDetailController : ControllerBase
    {
        private readonly IWhoWeAreDetailRepository _whoWeAreDetailRepository;

        public WhoWeAreDetailController(IWhoWeAreDetailRepository whoWeAreDetailRepository)
        {
            _whoWeAreDetailRepository = whoWeAreDetailRepository;
        }
        [HttpGet]
        public async Task<IActionResult> WhoWeAreDetailList()
        {
            var value = await _whoWeAreDetailRepository.GetAllWhoWeAreDetailAsync();
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateWhoWeAreDetails(CreateWhoWeAreDetailDto createWhoWeAreDetailDto)
        {
            _whoWeAreDetailRepository.AddWhoWeAreDetailAsync(createWhoWeAreDetailDto);
            return Ok("Hakkımızda yazısı başarlı bir şekilde eklendi.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDto updateWhoWeAreDetailDto)
        {
            _whoWeAreDetailRepository.UpdateWhoWeAreDetailAsync(updateWhoWeAreDetailDto);
            return Ok("Hakkımızda yazısı başarılı bir şekilde güncellendi.");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetWhoWeAreDetail(int id)
        {
            var value = await _whoWeAreDetailRepository.GetByIdWhoWeAreDetail(id);
            return Ok(value);   
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveWhoWeAreDetail(int id)
        {
            _whoWeAreDetailRepository.RemoveWhoWeAreDetailAsync(id);
            return Ok("Hakkımızda başarılı bir şekilde silindi.");
        }
    }
}
