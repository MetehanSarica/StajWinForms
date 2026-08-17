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
    private readonly ILogger<BiletlerController> _logger;

    public BiletlerController(DbStajContext context, ILogger<BiletlerController> logger)
    {
        _context = context;
        _logger = logger;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<BiletDto>>> GetBiletler()
    {
        var biletler = await _context.Biletlers
            .Select(b => new BiletDto
            {
                BiletId = b.BiletId,
                KoltukNo = b.KoltukNo,
                MusteriAdSoyad = (b.MusteriTcNavigation.Ad ?? "") + " " + (b.MusteriTcNavigation.Soyad ?? ""),
                MusteriTc = b.MusteriTc,
                SeferId = b.SeferId,
                KalkisSehirAdi = b.Sefer.KalkisSehir.SehirAdi,
                VarisSehirAdi = b.Sefer.VarisSehir.SehirAdi,
                KalkisZamani = b.Sefer.KalkisZamani,
                Fiyat = b.Sefer.Fiyat,
                Cinsiyet = b.Cinsiyet,
                BinisDurakSira = b.BinisDurakSira,
                InisDurakSira = b.InisDurakSira,
                FirmaAdi = b.Sefer.Firma.FirmaAdi ?? ""
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
                MusteriAdSoyad = (b.MusteriTcNavigation.Ad ?? "") + " " + (b.MusteriTcNavigation.Soyad ?? ""),
                MusteriTc = b.MusteriTc,
                SeferId = b.SeferId,
                KalkisSehirAdi = b.Sefer.KalkisSehir.SehirAdi,
                VarisSehirAdi = b.Sefer.VarisSehir.SehirAdi,
                KalkisZamani = b.Sefer.KalkisZamani,
                FirmaAdi = b.Sefer.Firma.FirmaAdi ?? "",
                Cinsiyet = b.Cinsiyet,
                BinisDurakSira = b.BinisDurakSira,
                InisDurakSira = b.InisDurakSira,
                Fiyat = b.Sefer.Fiyat

            })
            .ToListAsync();
        return Ok(biletler);
    }
    [HttpGet("musteri/{musteriTc}")]
    public async Task<ActionResult<IEnumerable<BiletDto>>> GetByMusteriTc(string musteriTc)
    {
        var biletler = await _context.Biletlers
            .Where(b => b.MusteriTc == musteriTc)
            .Select(b => new BiletDto
            {
                BiletId = b.BiletId,
                KoltukNo = b.KoltukNo,
                MusteriAdSoyad = (b.MusteriTcNavigation.Ad ?? "") + " " + (b.MusteriTcNavigation.Soyad ?? ""),
                MusteriTc = b.MusteriTc,
                SeferId = b.SeferId,
                KalkisSehirAdi = b.Sefer.KalkisSehir.SehirAdi,
                VarisSehirAdi = b.Sefer.VarisSehir.SehirAdi,
                KalkisZamani = b.Sefer.KalkisZamani,
                Cinsiyet = b.Cinsiyet,
                BinisDurakSira = b.BinisDurakSira,
                InisDurakSira = b.InisDurakSira,
                FirmaAdi = b.Sefer.Firma.FirmaAdi ?? "",
                Fiyat = b.Sefer.Fiyat
            })
            .ToListAsync();
        return Ok(biletler);
    }
    [HttpGet("detay/{biletId}")]
    public async Task<ActionResult<BiletDetayDto>> GetDetay(int biletId)
    {
        var b = await _context.Biletlers
            .Include(x => x.MusteriTcNavigation)
            .Include(x => x.Sefer).ThenInclude(x => x.KalkisSehir)
            .Include(x => x.Sefer).ThenInclude(x => x.VarisSehir)
            .Include(x => x.Sefer).ThenInclude(x => x.Firma)
            .FirstOrDefaultAsync(x => x.BiletId == biletId);

        if (b == null) return NotFound();

        return Ok(new BiletDetayDto
        {
            BiletId = b.BiletId,
            KoltukNo = b.KoltukNo,
            SeferId = b.SeferId,
            MusteriAd = b.MusteriTcNavigation.Ad,
            MusteriSoyad = b.MusteriTcNavigation.Soyad,
            MusteriTc = b.MusteriTc,
            MusteriTelefon = b.MusteriTcNavigation.Telefon ?? "",
            MusteriEmail = b.MusteriTcNavigation.Email ?? "",
            MusteriSehir = b.MusteriTcNavigation.Sehir ?? "",
            MusteriAdres = b.MusteriTcNavigation.Adres ?? "",
            Cinsiyet = b.Cinsiyet ?? "",
            KalkisSehirAdi = b.Sefer.KalkisSehir.SehirAdi,
            VarisSehirAdi = b.Sefer.VarisSehir.SehirAdi,
            KalkisZamani = b.Sefer.KalkisZamani,
            FirmaAdi = b.Sefer.Firma.FirmaAdi ?? "",
            Fiyat = b.Sefer.Fiyat,
            SatinAlmaTarihi = b.SatinAlmaTarihi
        });
    }
    [HttpGet("ara")]
    public async Task<ActionResult<IEnumerable<BiletDto>>> Ara(
        [FromQuery] int? kalkisId,
        [FromQuery] int? varisId,
        [FromQuery] DateTime? tarih)
    {
        var query = _context.Biletlers.AsQueryable();

        if (kalkisId.HasValue)
            query = query.Where(b => b.Sefer.KalkisSehirId == kalkisId.Value);
        if (varisId.HasValue)
            query = query.Where(b => b.Sefer.VarisSehirId ==  varisId.Value);
        if (tarih.HasValue)
            query = query.Where(b => b.Sefer.KalkisZamani.Date == tarih.Value.Date);

        var biletler = await query.Select(b => new BiletDto
        {
            BiletId = b.BiletId,
            KoltukNo = b.KoltukNo,
            MusteriAdSoyad = (b.MusteriTcNavigation.Ad ?? "") + " " + (b.MusteriTcNavigation.Soyad ?? ""),
            MusteriTc = b.MusteriTc,
            SeferId = b.SeferId,
            KalkisSehirAdi = b.Sefer.KalkisSehir.SehirAdi,
            VarisSehirAdi = b.Sefer.VarisSehir.SehirAdi,
            KalkisZamani = b.Sefer.KalkisZamani,
            FirmaAdi = b.Sefer.Firma.FirmaAdi ?? "",
            Fiyat = b.Sefer.Fiyat,
            Cinsiyet = b.Cinsiyet,
            BinisDurakSira = b.BinisDurakSira,
            InisDurakSira = b.InisDurakSira
        }).ToListAsync();

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

        var koltukDolu = await _context.Biletlers.AnyAsync(b =>
            b.SeferId == dto.SeferId &&
            b.KoltukNo == dto.KoltukNo &&
            b.BinisDurakSira < dto.InisDurakSira &&
            b.InisDurakSira > dto.BinisDurakSira);

        if (koltukDolu)
            return Conflict($"Koltuk {dto.KoltukNo} seçilen güzergah için dolu.");

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
    [HttpPost("satinal")]
    public async Task<ActionResult> SatinAlBilet(SatinAlDto satinAlDto)
    {
        // Serializable: doluluk kontrolü ile insert arasına başka satışın girmesini engeller
        await using var transaction = await _context.Database
            .BeginTransactionAsync(System.Data.IsolationLevel.Serializable);
        try
        {
            var koltukDolu = await _context.Biletlers.AnyAsync(b =>
                b.SeferId == satinAlDto.SeferId &&
                b.KoltukNo == satinAlDto.KoltukNo &&
                b.BinisDurakSira < satinAlDto.InisDurakSira &&
                b.InisDurakSira > satinAlDto.BinisDurakSira);

            if (koltukDolu)
                return Conflict($"Koltuk {satinAlDto.KoltukNo} seçilen güzergah için dolu.");

            var musteriVarMi = await _context.Musteris.AnyAsync(m => m.Tc == satinAlDto.MusteriTc);
            if (!musteriVarMi)
            {
                var mailKullanimda = await _context.Musteris.AnyAsync(m => m.Email == satinAlDto.MusteriMail);
                if (mailKullanimda)
                    return Conflict($"'{satinAlDto.MusteriMail}' e-posta adresi başka bir müşteriye kayıtlı.");

                _context.Musteris.Add(new Musteri
                {
                    Tc = satinAlDto.MusteriTc,
                    Ad = satinAlDto.MusteriAd,
                    Soyad = satinAlDto.MusteriSoyad,
                    Email = Convert.ToString(satinAlDto.MusteriMail),
                    Telefon = satinAlDto.MusteriTelefon,
                    Sehir = satinAlDto.MusteriSehir,
                    Adres = satinAlDto.MusteriAdres,
                    Cinsiyet = satinAlDto.MusteriCinsiyet
                });
            }

            var seferVarMi = await _context.Seferlers.AnyAsync(s => s.SeferId == satinAlDto.SeferId);
            if (!seferVarMi)
                return BadRequest($"SeferId {satinAlDto.SeferId} bulunamadı.");

            var yeniBilet = new Biletler
            {
                SeferId = satinAlDto.SeferId,
                KoltukNo = satinAlDto.KoltukNo,
                MusteriTc = satinAlDto.MusteriTc,
                BinisDurakSira = satinAlDto.BinisDurakSira,
                InisDurakSira = satinAlDto.InisDurakSira,
                Cinsiyet = satinAlDto.MusteriCinsiyet,
                SatinAlmaTarihi = DateTime.Now
            };
            _context.Biletlers.Add(yeniBilet);
            await _context.SaveChangesAsync();
            await transaction.CommitAsync();
            return Ok(new { mesaj = "Bilet satın alındı", biletId = yeniBilet.BiletId });
        }
        catch (Exception ex)
        {
            await transaction.RollbackAsync();
            _logger.LogError(ex, "SatinAlBilet işlemi başarısız. SeferId={SeferId} KoltukNo={KoltukNo}",
                satinAlDto.SeferId, satinAlDto.KoltukNo);
            return StatusCode(500, "İşlem sırasında hata oluştu.");
        }
    }

    [HttpDelete("{biletId}")]
    public async Task<ActionResult> DeleteBilet(int biletId)
    {
        var bilet = await _context.Biletlers.FindAsync(biletId);
        if (bilet == null)
            return NotFound($"BiletId {biletId} bulunamadı.");
        _context.Biletlers.Remove(bilet);
        await _context.SaveChangesAsync();
        return Ok(new { mesaj = "Bilet silindi", biletId = biletId });
    }

}