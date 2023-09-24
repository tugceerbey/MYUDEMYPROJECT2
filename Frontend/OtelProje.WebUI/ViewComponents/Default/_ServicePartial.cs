using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OtelProje.WebUI.Dtos.RoomDto;
using OtelProje.WebUI.Dtos.ServiceDto;

namespace OtelProje.WebUI.ViewComponents.Default
{
    public class _ServicePartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _ServicePartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5043/api/Service");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultServiceDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
