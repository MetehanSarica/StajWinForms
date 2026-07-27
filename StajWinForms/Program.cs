using Microsoft.Extensions.Configuration;
using System.Net.Http;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace StajWinForms
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
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

            WindowsFormsSettings.TrackWindowsAccentColor = DefaultBoolean.True;

            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("WXI");

            bool adminMod = args.Length > 0 && args[0].Equals("adminp", StringComparison.OrdinalIgnoreCase);

            if (adminMod)
            {
                while (true)
                {
                    var loginForm = new LoginForm();
                    if (loginForm.ShowDialog() != DialogResult.OK) break;
                    var panel = new AdminPanelForm();
                    Application.Run(panel);
                    if (!panel.CikisYapildi) break;
                }
            }
            else
            {
                Application.Run(new SeferSecimMenu());
            }
        }
    }

    public static class AppConfig
    {
        public static string ApiBaseUrl { get; set; } = "";
        public static string ApiKey { get; set; } = "";

        private static readonly Lazy<HttpClient> _http = new(() =>
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(ApiBaseUrl),
                Timeout = TimeSpan.FromSeconds(30)
            };
            client.DefaultRequestHeaders.Add("X-Api-Key", ApiKey);
            return client;
        });

        public static HttpClient Http => _http.Value;
    }
}