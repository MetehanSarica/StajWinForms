using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StajWinForms_API.Models;
using StajWinForms_API.Dtos;

namespace StajWinForms_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SeferlerController : ControllerBase
{
    private readonly DbStajContext _context;

    public SeferlerController(DbStajContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<SeferlerDto>>> GetSeferler()
    {
        var seferler = await _context.Seferlers
            .Select(s => new SeferlerDto
            {
                FirmaId = s.FirmaId,
                KalkisSehirId = s.KalkisSehirId,
                VarisSehirId = s.VarisSehirId,
                SeferId = s.SeferId,
                KalkisZamani = s.KalkisZamani,
                Fiyat = s.Fiyat,
                FirmaAdi = s.Firma.FirmaAdi ?? "",
                KalkisSehirAdi = s.KalkisSehir.SehirAdi,
                VarisSehirAdi = s.VarisSehir.SehirAdi,
                OtobusId = s.OtobusId,
                OtobusPlaka = s.Otobus != null ? s.Otobus.Plaka : null
            })
            .ToListAsync();

        return Ok(seferler);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] SeferCreateDto dto)
    {
        var sefer = new Seferler
        {
            FirmaId = dto.FirmaId,
            KalkisSehirId = dto.KalkisSehirId,
            VarisSehirId = dto.VarisSehirId,
            KalkisZamani = dto.KalkisZamani,
            SureDakika = dto.SureDakika,
            Fiyat = dto.Fiyat,
            KoltukKapasitesi = dto.KoltukKapasitesi,
            BosKoltuk = dto.KoltukKapasitesi
        };
        _context.Seferlers.Add(sefer);
        await _context.SaveChangesAsync();
        return Ok(new { sefer.SeferId });
    }

    [HttpPut("{id}/otobus")]
    public async Task<IActionResult> OtobusAta(int id, [FromBody] SeferOtobusAtaDto dto)
    {
        var sefer = await _context.Seferlers.FindAsync(id);
        if (sefer == null) return NotFound();

        var otobus = await _context.Otobuslers.FindAsync(dto.OtobusId);
        if (otobus == null) return BadRequest("Otobüs bulunamadı.");

        sefer.OtobusId = dto.OtobusId;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] SeferCreateDto dto)
    {
        var sefer = await _context.Seferlers.FindAsync(id);
        if (sefer == null) return NotFound();

        sefer.FirmaId = dto.FirmaId;
        sefer.KalkisSehirId = dto.KalkisSehirId;
        sefer.VarisSehirId = dto.VarisSehirId;
        sefer.KalkisZamani = dto.KalkisZamani;
        sefer.SureDakika = dto.SureDakika;
        sefer.Fiyat = dto.Fiyat;
        sefer.KoltukKapasitesi = dto.KoltukKapasitesi;

        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}/otobus")]
    public async Task<IActionResult> OtobusKaldir(int id)
    {
        var sefer = await _context.Seferlers.FindAsync(id);
        if (sefer == null) return NotFound();

        sefer.OtobusId = null;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var sefer = await _context.Seferlers.FindAsync(id);
        if (sefer == null) return NotFound();

        var biletVarMi = await _context.Biletlers.AnyAsync(b => b.SeferId == id);
        if (biletVarMi)
            return Conflict("Bu sefere ait biletler var, silinemez.");

        _context.Seferlers.Remove(sefer);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
