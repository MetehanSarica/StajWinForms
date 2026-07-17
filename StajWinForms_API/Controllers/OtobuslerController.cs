using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StajWinForms_API.Dtos;
using StajWinForms_API.Models;

namespace StajWinForms_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OtobuslerController : ControllerBase
{
    private readonly DbStajContext _context;

    public OtobuslerController(DbStajContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<OtobusDto>>> GetOtobusler()
    {
        var liste = await _context.Otobuslers
            .Include(o => o.Firma)
            .Select(o => new OtobusDto
            {
                OtobusId = o.OtobusId,
                Plaka = o.Plaka,
                Marka = o.Marka,
                Model = o.Model,
                KoltukKapasitesi = o.KoltukKapasitesi,
                FirmaId = o.FirmaId,
                FirmaAdi = o.Firma != null ? o.Firma.FirmaAdi : null
            })
            .ToListAsync();

        return Ok(liste);
    }

    [HttpPost]
    public async Task<ActionResult<OtobusDto>> OtobusEkle([FromBody] OtobusOlusturDto dto)
    {
        if (await _context.Otobuslers.AnyAsync(o => o.Plaka == dto.Plaka))
            return Conflict("Bu plaka zaten kayıtlı.");

        var otobus = new Otobusler
        {
            Plaka = dto.Plaka,
            Marka = dto.Marka,
            Model = dto.Model,
            KoltukKapasitesi = dto.KoltukKapasitesi,
            FirmaId = dto.FirmaId
        };

        _context.Otobuslers.Add(otobus);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetOtobusler), new { id = otobus.OtobusId }, new OtobusDto
        {
            OtobusId = otobus.OtobusId,
            Plaka = otobus.Plaka,
            Marka = otobus.Marka,
            Model = otobus.Model,
            KoltukKapasitesi = otobus.KoltukKapasitesi,
            FirmaId = otobus.FirmaId
        });
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> OtobusGuncelle(int id, [FromBody] OtobusOlusturDto dto)
    {
        var otobus = await _context.Otobuslers.FindAsync(id);
        if (otobus == null) return NotFound();

        if (await _context.Otobuslers.AnyAsync(o => o.Plaka == dto.Plaka && o.OtobusId != id))
            return Conflict("Bu plaka başka bir otobüste kayıtlı.");

        otobus.Plaka = dto.Plaka;
        otobus.Marka = dto.Marka;
        otobus.Model = dto.Model;
        otobus.KoltukKapasitesi = dto.KoltukKapasitesi;
        otobus.FirmaId = dto.FirmaId;

        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> OtobusSil(int id)
    {
        var otobus = await _context.Otobuslers.FindAsync(id);
        if (otobus == null) return NotFound();

        _context.Otobuslers.Remove(otobus);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpPut("{id}/firma")]
    public async Task<IActionResult> FirmaEsle(int id, [FromBody] int? firmaId)
    {
        var otobus = await _context.Otobuslers.FindAsync(id);
        if (otobus == null) return NotFound();

        if (firmaId.HasValue && !await _context.Firmalars.AnyAsync(f => f.FirmaId == firmaId))
            return BadRequest("Geçersiz firma.");

        otobus.FirmaId = firmaId;
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
