namespace StajWinForms
{
    internal static class Dogrulama
    {
        public static bool TcGecerliMi(string tc) =>
            tc.Length == 11 && tc[0] != '0' && tc.All(char.IsDigit);

        public static bool TelefonGecerliMi(string tel) =>
            tel.Length == 11 && tel[0] == '0' && tel.All(char.IsDigit);
    }
}
