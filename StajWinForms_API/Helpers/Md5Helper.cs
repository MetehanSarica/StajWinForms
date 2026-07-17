using System.Security.Cryptography;
using System.Text;

namespace StajWinForms_API.Helpers;

public static class Md5Helper
{
    public static string Hash(string deger)
    {
        var bytes = MD5.HashData(Encoding.UTF8.GetBytes(deger));
        return Convert.ToHexString(bytes).ToLowerInvariant();
    }
}
