using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OtelProje.WebUI.Dtos.StaffDto;

namespace OtelProje.WebUI.ViewComponents.Dashboard
{
    public class _DashboardLast4StaffList:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _DashboardLast4StaffList(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:2758/api/Staff/Last4Staff");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultLast4StaffDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
