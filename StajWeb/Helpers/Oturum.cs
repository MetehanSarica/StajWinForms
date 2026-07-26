using System.Text.Json;
using StajWeb.Dtos;

namespace StajWeb.Helpers
{
    public static class Oturum
    {
        private const string Anahtar = "oturum";

        public static void GirisYap(this ISession session, LoginSonucDto sonuc)
            => session.SetString(Anahtar, JsonSerializer.Serialize(sonuc));

        public static LoginSonucDto? GetOturum(this ISession session)
        {
            var json = session.GetString(Anahtar);
            return json == null ? null : JsonSerializer.Deserialize<LoginSonucDto>(json);
        }

        public static bool GirisliMi(this ISession session)
            => session.GetString(Anahtar) != null;

        public static KullaniciYetkiDto? GetYetki(this ISession session, string formAdi)
            => session.GetOturum()?.Yetkiler.FirstOrDefault(y => y.FormAdi == formAdi);
    }
}
