using Microsoft.AspNetCore.Mvc;
using MYRealEStateDapperUI.Dtos.TestimonialDtos;
using Newtonsoft.Json;

namespace MYRealEStateDapperUI.ViewComponents.HomePage
{
    public class _HomeOurTestimonialComponent : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _HomeOurTestimonialComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44394/api/Testimonial");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<List<ResultTestimonialDto>>(jsonData);
                return View(value);
            }
            return View();
        }
    }
}
