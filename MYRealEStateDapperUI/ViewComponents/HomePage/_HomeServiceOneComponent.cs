using Microsoft.AspNetCore.Mvc;
using MYRealEStateDapperUI.Dtos.BottomGridDtos;
using Newtonsoft.Json;

namespace MYRealEStateDapperUI.ViewComponents.HomePage
{
    public class _HomeServiceOneComponent : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _HomeServiceOneComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44394/api/BottomGrid");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBottomGridDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
