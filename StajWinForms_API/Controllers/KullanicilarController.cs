using Microsoft.AspNetCore.Components.Forms;
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

        var formlar = await _context.Formlar.ToListAsync();
        foreach (var f in formlar)
        {
            _context.KullaniciYetkileri.Add(new KullaniciYetkileri
            {
                KullaniciId = kullanici.KullaniciId,
                FormId = f.FormId
            });
        }

        /* 
         *      Eski FormAdlari
         * 
         * var formAdlari = new[]             
        {
        "btnFirmaBrowser", "btnOtobusBrowser", "btnFirmaOtobusEsle",
        "btnKaptanBrowser", "btnKaptanEsle", "btnSeferOtobusEsle",
        "btnKullaniciYonetim", "btnYetkiAtama"
        };

        foreach (var f in formAdlari)
        {
            _context.KullaniciYetkileri.Add(new KullaniciYetkileri
            {
                KullaniciId = kullanici.KullaniciId,
                FormAdi = f
            });
        } */

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

        var yetkiler = _context.KullaniciYetkileri.Where(ky => ky.KullaniciId == id);
        _context.KullaniciYetkileri.RemoveRange(yetkiler);

        _context.Kullanicilars.Remove(kullanici);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpGet("{id}/yetkiler")]
    public async Task<ActionResult<IEnumerable<KullaniciYetkiDto>>> GetYetkiler(int id)
    {
        var kullanici = await _context.Kullanicilars
            .Include(k => k.KullaniciYetkileri)
            .ThenInclude(ky => ky.Form)
            .FirstOrDefaultAsync(k => k.KullaniciId == id);

        if (kullanici == null) return NotFound();

        return Ok(kullanici.KullaniciYetkileri
            .Select(ky => new KullaniciYetkiDto
            {
                FormAdi = ky.Form!.FormAdi,
                Ekle = ky.Ekle,
                Sil = ky.Sil,
                Degistir = ky.Degistir,
                Incele = ky.Incele,
                Ata = ky.Ata,
                Kaldir = ky.Kaldir,
                Kaydet = ky.Kaydet,
                AktifPasif = ky.AktifPasif,
            }).ToList());
    }

    [HttpPut("{id}/yetkiler")]
    public async Task<IActionResult> YetkiGuncelle(int id, [FromBody] List<KullaniciYetkiDto> yetkiler)
    {
        var kullanici = await _context.Kullanicilars
            .Include(k => k.KullaniciYetkileri)
            .FirstOrDefaultAsync(k => k.KullaniciId == id);

        if (kullanici == null) return NotFound();

        foreach (var dto in yetkiler)
        {
            var form = await _context.Formlar.FirstOrDefaultAsync(f => f.FormAdi == dto.FormAdi);
            
            if (form == null)
            {
                continue;
            }
            
            var satir = kullanici.KullaniciYetkileri
                .FirstOrDefault(ky => ky.FormId == form!.FormId);

            if (satir == null)
            {
                satir = new KullaniciYetkileri
                {
                    KullaniciId = id,
                    FormId = form.FormId
                };
                _context.KullaniciYetkileri.Add(satir);
                kullanici.KullaniciYetkileri.Add(satir);
            }

            if (kullanici.KullaniciAdi == "metehansarica")
            {
                satir.Ekle = satir.Ekle || dto.Ekle;
                satir.Sil = satir.Sil || dto.Sil;
                satir.Degistir = satir.Degistir || dto.Degistir;
                satir.Incele = satir.Incele || dto.Incele;
                satir.Ata = satir.Ata || dto.Ata;
                satir.Kaldir = satir.Kaldir || dto.Kaldir;
                satir.Kaydet = satir.Kaydet || dto.Kaydet;
                satir.AktifPasif = satir.AktifPasif || dto.AktifPasif;
            }
            else
            {
                satir.Ekle = dto.Ekle;
                satir.Sil = dto.Sil;
                satir.Degistir = dto.Degistir;
                satir.Incele = dto.Incele;
                satir.Ata = dto.Ata;
                satir.Kaldir = dto.Kaldir;
                satir.Kaydet = dto.Kaydet;
                satir.AktifPasif = dto.AktifPasif;
            }
        }

        await _context.SaveChangesAsync();
        return NoContent();
    }
}
