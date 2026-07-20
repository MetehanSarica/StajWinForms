using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StajWinForms_API.Dtos;
using StajWinForms_API.Helpers;
using StajWinForms_API.Models;

namespace StajWinForms_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class KullanicilarController : ControllerBase
{
    private readonly DbStajContext _context;

    public KullanicilarController(DbStajContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<KullaniciGosterDto>>> GetKullanicilar()
    {
        var liste = await _context.Kullanicilars
            .Select(k => new KullaniciGosterDto
            {
                KullaniciId = k.KullaniciId,
                KullaniciAdi = k.KullaniciAdi,
                AdSoyad = k.AdSoyad,
                Aktif = k.Aktif,
                OlusturmaTarihi = k.OlusturmaTarihi
            })
            .ToListAsync();

        return Ok(liste);
    }

    [HttpPost]
    public async Task<ActionResult<KullaniciGosterDto>> KullaniciOlustur([FromBody] KullaniciOlusturDto dto)
    {
        if (await _context.Kullanicilars.AnyAsync(k => k.KullaniciAdi == dto.KullaniciAdi))
            return Conflict("Bu kullanıcı adı zaten kullanılıyor.");

        var kullanici = new Kullanicilar
        {
            KullaniciAdi = dto.KullaniciAdi,
            SifreMd5 = Md5Helper.Hash(dto.Sifre),
            AdSoyad = dto.AdSoyad,
            Aktif = dto.Aktif,
            OlusturmaTarihi = DateTime.Now
        };

        _context.Kullanicilars.Add(kullanici);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetKullanicilar), new { id = kullanici.KullaniciId }, new KullaniciGosterDto
        {
            KullaniciId = kullanici.KullaniciId,
            KullaniciAdi = kullanici.KullaniciAdi,
            AdSoyad = kullanici.AdSoyad,
            Aktif = kullanici.Aktif,
            OlusturmaTarihi = kullanici.OlusturmaTarihi
        });
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> KullaniciGuncelle(int id, [FromBody] KullaniciGuncelleDto dto)
    {
        var kullanici = await _context.Kullanicilars.FindAsync(id);
        if (kullanici == null) return NotFound();

        if (await _context.Kullanicilars.AnyAsync(k => k.KullaniciAdi == dto.KullaniciAdi && k.KullaniciId != id))
            return Conflict("Bu kullanıcı adı zaten kullanılıyor.");

        kullanici.KullaniciAdi = dto.KullaniciAdi;
        kullanici.AdSoyad = dto.AdSoyad;
        kullanici.Aktif = dto.Aktif;

        if (!string.IsNullOrWhiteSpace(dto.YeniSifre))
            kullanici.SifreMd5 = Md5Helper.Hash(dto.YeniSifre);

        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> KullaniciSil(int id)
    {
        var kullanici = await _context.Kullanicilars.FindAsync(id);
        if (kullanici == null) return NotFound();

        if (kullanici.KullaniciAdi == "metehansarica")
            return BadRequest("Bu kullanıcı silinemez.");

        _context.Kullanicilars.Remove(kullanici);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpGet("{id}/yetkiler")]
    public async Task<ActionResult<IEnumerable<string>>> GetYetkiler(int id)
    {
        var kullanici = await _context.Kullanicilars
            .Include(k => k.KullaniciYetkileri)
                .ThenInclude(ky => ky.Yetki)
            .FirstOrDefaultAsync(k => k.KullaniciId == id);

        if (kullanici == null) return NotFound();

        return Ok(kullanici.KullaniciYetkileri.Select(ky => ky.Yetki.YetkiKodu).ToList());
    }

    [HttpPut("{id}/yetkiler")]
    public async Task<IActionResult> YetkiGuncelle(int id, [FromBody] List<string> yetkiKodlari)
    {
        var kullanici = await _context.Kullanicilars
            .Include(k => k.KullaniciYetkileri)
            .FirstOrDefaultAsync(k => k.KullaniciId == id);

        if (kullanici == null) return NotFound();

        if (kullanici.KullaniciAdi == "metehansarica")
            return BadRequest("Bu kullanıcının yetkileri değiştirilemez.");

        var tumYetkiler = await _context.Yetkilers.ToListAsync();
        var hedefYetkiler = tumYetkiler.Where(y => yetkiKodlari.Contains(y.YetkiKodu)).ToList();

        _context.KullaniciYetkileri.RemoveRange(kullanici.KullaniciYetkileri);

        foreach (var yetki in hedefYetkiler)
        {
            _context.KullaniciYetkileri.Add(new KullaniciYetkileri
            {
                KullaniciId = id,
                YetkiId = yetki.YetkiId
            });
        }

        await _context.SaveChangesAsync();
        return NoContent();
    }
}
