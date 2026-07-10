using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StajWinForms_API.Models;
using StajWinForms_API.Dtos;

namespace StajWinForms_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BiletlerController : ControllerBase
{
    private readonly DbStajContext _context;

    public BiletlerController(DbStajContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<BiletDto>>> GetBiletler()
    {
        var biletler = await _context.Biletlers
            .Select(b => new BiletDto
            {
                BiletId = b.BiletId,
                KoltukNo = b.KoltukNo,
                MusteriAdSoyad = b.MusteriTcNavigation.Ad + " " + b.MusteriTcNavigation.Soyad,
                MusteriTc = b.MusteriTc,
                SeferId = b.SeferId,
                KalkisSehirAdi = b.Sefer.KalkisSehir.SehirAdi,
                VarisSehirAdi = b.Sefer.VarisSehir.SehirAdi,
                KalkisZamani = b.Sefer.KalkisZamani,
                Cinsiyet = b.Cinsiyet
            })
            .ToListAsync();

        return Ok(biletler);
    }

    [HttpGet("{seferId}")]
    public async Task<ActionResult<IEnumerable<BiletDto>>> GetBySeferId(int seferId)
    {
        var biletler = await _context.Biletlers
            .Where(b => b.SeferId == seferId)
            .Select(b => new BiletDto
            {
                BiletId = b.BiletId,
                KoltukNo = b.KoltukNo,
                MusteriAdSoyad = b.MusteriTcNavigation.Ad + " " + b.MusteriTcNavigation.Soyad,
                MusteriTc = b.MusteriTc,
                SeferId = b.SeferId,
                KalkisSehirAdi = b.Sefer.KalkisSehir.SehirAdi,
                VarisSehirAdi = b.Sefer.VarisSehir.SehirAdi,
                KalkisZamani = b.Sefer.KalkisZamani,
                Cinsiyet = b.Cinsiyet,
                BinisDurakSira = b.BinisDurakSira,
                InisDurakSira = b.InisDurakSira
            })
            .ToListAsync();
        return Ok(biletler);
    }

    [HttpPost]
    public async Task<ActionResult> CreateBilet(CreateBiletDto dto)
    {
        var musteriVarMi = await _context.Musteris.AnyAsync(m => m.Tc == dto.MusteriTc);
        if (!musteriVarMi)
            return BadRequest($"TC {dto.MusteriTc} ile kayıtlı müşteri bulunamadı.");

        var seferVarMi = await _context.Seferlers.AnyAsync(s => s.SeferId == dto.SeferId);
        if (!seferVarMi)
            return BadRequest($"SeferId {dto.SeferId} bulunamadı.");

        var yeniBilet = new Biletler
        {
            SeferId = dto.SeferId,
            KoltukNo = dto.KoltukNo,
            MusteriTc = dto.MusteriTc,
            BinisDurakSira = dto.BinisDurakSira,
            InisDurakSira = dto.InisDurakSira,
            Cinsiyet = dto.Cinsiyet
        };

        _context.Biletlers.Add(yeniBilet);
        await _context.SaveChangesAsync();

        return Ok(new { mesaj = "Bilet oluşturuldu", biletId = yeniBilet.BiletId });
    }

}