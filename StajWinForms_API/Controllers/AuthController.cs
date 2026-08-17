using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StajWinForms_API.Dtos;
using StajWinForms_API.Helpers;
using StajWinForms_API.Models;

namespace StajWinForms_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly DbStajContext _context;
    private readonly ILogger<AuthController> _logger;

    public AuthController(DbStajContext context, ILogger<AuthController> logger)
    {
        _context = context;
        _logger = logger;
    }

    [HttpPost("login")]
    public async Task<ActionResult<LoginSonucDto>> Login([FromBody] LoginDto dto)
    {
        var sifreMd5 = Md5Helper.Hash(dto.Sifre);

        var kullanici = await _context.Kullanicilars
            .Include(k => k.KullaniciYetkileri)
            .ThenInclude(ky => ky.Form)
            .FirstOrDefaultAsync(k => k.KullaniciAdi == dto.KullaniciAdi && k.SifreMd5 == sifreMd5);

        if (kullanici == null)
            {
            _logger.LogWarning("Başarısız giriş denemesi. KullaniciAdi={KullaniciAdi}", dto.KullaniciAdi);
            return Unauthorized("Kullanıcı adı veya şifre hatalı.");
            }

        if (!kullanici.Aktif)
            {
            _logger.LogWarning("Pasif hesaba giriş denemesi. KullaniciAdi={KullaniciAdi}", dto.KullaniciAdi);
            return Unauthorized("Bu hesap pasif durumda.");
            }

        var sonuc = new LoginSonucDto
        {
            KullaniciId = kullanici.KullaniciId,
            KullaniciAdi = kullanici.KullaniciAdi,
            AdSoyad = kullanici.AdSoyad,
            Yetkiler = kullanici.KullaniciYetkileri
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
                })
                .ToList()
        };
        return Ok(sonuc);
    }
}
