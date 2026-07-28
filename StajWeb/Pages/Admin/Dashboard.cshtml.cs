using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StajWeb.Dtos;
using System.Net.Http.Json;

namespace StajWeb.Pages.Admin
{
    public class DashboardModel : AdminPageModel
    {
        private readonly IHttpClientFactory _clientFactory;
        public DashboardModel(IHttpClientFactory clientFactory) => _clientFactory = clientFactory;

        public IstatistikDto Istatistik { get; set; } = new();

        public async Task OnGetAsync()
        {
            var client = _clientFactory.CreateClient("API");
            Istatistik = await client.GetFromJsonAsync<IstatistikDto>("api/istatistikler") ?? new();
        }
    }
}
