using Microsoft.AspNetCore.Mvc;
using MYRealEStateDapperUI.Dtos.ProductDtos;
using Newtonsoft.Json;

namespace MYRealEStateDapperUI.ViewComponents.HomePage
{
    public class _HomeProductListComponent : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _HomeProductListComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44394/api/Products/GetAllProductWithCategoryList");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
                return View(value);
            }
            return View();
        }
    }
}
