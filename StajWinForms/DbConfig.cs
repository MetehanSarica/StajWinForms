using System.IO;
using System.Text.Json;

namespace StajWinForms
{
    internal static class DbConfig
    {
        public static string ConnectionString { get; } = Load();

        private static string Load()
        {
            var path = Path.Combine(AppContext.BaseDirectory, "appsettings.json");
            using var doc = JsonDocument.Parse(File.ReadAllText(path));
            return doc.RootElement
                .GetProperty("ConnectionStrings")
                .GetProperty("DbStajConnection")
                .GetString()!;
        }
    }
}
