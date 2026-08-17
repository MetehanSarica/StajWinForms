using System;
using System.Collections.Generic;
using System.Text;

namespace StajWinForms.Tests
{
    public class TcValidasyonTests
    {
        private static bool TcGecerliMi(string tc)
        {
            if (string.IsNullOrEmpty(tc) || tc.Length != 11 || tc[0] == '0' || !tc.All(char.IsDigit))
                return false;
            int[] h = tc.Select(c => c - '0').ToArray();
            int hane10 = ((h[0] + h[2] + h[4] + h[6] + h[8]) * 7 - (h[1] + h[3] + h[5] + h[7])) % 10;
            if (hane10 < 0) hane10 += 10;
            return hane10 == h[9] && h.Take(10).Sum() % 10 == h[10];
        }

        [Fact] public void BosString_False() => Assert.False(TcGecerliMi(""));
        [Fact] public void SifirBaslayan_False() => Assert.False(TcGecerliMi("01234567890"));
        [Fact] public void OnHaneli_False() => Assert.False(TcGecerliMi("1234567890"));
        [Fact] public void HarfIceren_False() => Assert.False(TcGecerliMi("1234567890A"));
        [Fact] public void GecerliTc_True() => Assert.True(TcGecerliMi("10000000146"));
    }
}
