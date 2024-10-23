using Microsoft.AspNetCore.Mvc;
using MYRealEStateDapperUI.Dtos.PopulerLocationDtos;
using Newtonsoft.Json;

namespace MYRealEStateDapperUI.ViewComponents.HomePage
{
    public class _HomeProductExpolereCityComponent : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _HomeProductExpolereCityComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44394/api/PopulerLocations");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<List<ResultPopulerLocationDto>>(jsonData);
                return View(value);
            }
            return View();
        }
    }
}
