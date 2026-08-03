using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StajWinForms_API.Dtos;
using StajWinForms_API.Models;

namespace StajWinForms_API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class IstatistiklerController : ControllerBase
    {
        private readonly DbStajContext _context;

        public IstatistiklerController(DbStajContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task <ActionResult<IstatistikDto>> Get()
        {
            var bugun = DateTime.Today;

            var toplamBilet = await _context.Biletlers.CountAsync();

            var bugunkuGelir = await _context.Biletlers
                .SumAsync(b => (decimal?)b.Sefer.Fiyat) ?? 0;

            var aktifSefer = await _context.Seferlers.CountAsync();

            var populer = await _context.Biletlers
                .GroupBy(b => new
                {
                    Kalkis = b.Sefer.KalkisSehir.SehirAdi,
                    Varis = b.Sefer.VarisSehir.SehirAdi
                })
                .Select(g => new GuzergahIstatistikDto
                {
                    Guzergah = g.Key.Kalkis + " → " + g.Key.Varis,
                    BiletSayisi = g.Count()
                })
                .OrderByDescending(g => g.BiletSayisi)
                .Take(5)
                .ToListAsync();

            var firmaGelirler = await _context.Biletlers
                .GroupBy(b => b.Sefer.Firma.FirmaAdi)
                .Select(g => new FirmaGelirDto
                {
                    FirmaAdi = g.Key ?? "Bilinmiyor",
                    ToplamGelir = g.Sum(b => (decimal?)b.Sefer.Fiyat) ?? 0,
                    BiletSayisi = g.Count()
                })
                .OrderByDescending(f => f.ToplamGelir)
                .ToListAsync();

            return Ok(new IstatistikDto
            {
                ToplamBilet = toplamBilet,
                ToplamGelir = bugunkuGelir,
                AktifSeferler = aktifSefer,
                PopulerGuzergahlar = populer,
                FirmaGelirler = firmaGelirler
            });
        }
    }
}
