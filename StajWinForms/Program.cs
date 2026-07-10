using Microsoft.Extensions.Configuration;
using System.Net.Http;

namespace StajWinForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            AppConfig.ApiBaseUrl = config["ApiBaseUrl"]!;
            AppConfig.ApiKey = config["ApiKey"]!;

            QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            ApplicationConfiguration.Initialize();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2019 Colorful");
            Application.Run(new SeferSecimMenu());
        }
    }

    public static class AppConfig
    {
        public static string ApiBaseUrl { get; set; } = "";
        public static string ApiKey { get; set; } = "";

        public static HttpClient CreateHttpClient()
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(ApiBaseUrl),
                Timeout = TimeSpan.FromSeconds(30)
            };
            client.DefaultRequestHeaders.Add("X-Api-Key", ApiKey);
            return client;
        }
    }
}