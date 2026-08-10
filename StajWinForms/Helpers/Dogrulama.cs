namespace StajWinForms
{
    internal static class Dogrulama
    {
        public static bool TcGecerliMi(string tc)
        {
            if (string.IsNullOrEmpty(tc) || tc.Length != 11) 
                return false;

            if (tc[0] == '0')
                return false;

            if (!tc.All(char.IsDigit))
                return false;

            int[] haneler = tc.Select(c => int.Parse(c.ToString())).ToArray();

            int teklerToplami = haneler[0] + haneler[2] + haneler[4] + haneler[6] + haneler[8];
            int ciftlerToplami = haneler[1] + haneler[3] + haneler[5] + haneler[7];

            int hane10 = ((teklerToplami * 7) - ciftlerToplami) % 10;

            if (hane10 < 0) hane10 += 10;

            if (hane10 != haneler[9])
                return false;

            int ilk10Toplam = haneler.Take(10).Sum();
            int hane11 = ilk10Toplam % 10;

            if (hane11 != haneler[10])
                return false;

            return true;
        }

        public static bool TelefonGecerliMi(string tel) =>
            tel.Length == 11 && tel[0] == '0' && tel.All(char.IsDigit);

        public static bool EmailGecerliMi(string email)
        {
            try { return new System.Net.Mail.MailAddress(email).Address == email; }
            catch { return false; }
        }
    }
}
