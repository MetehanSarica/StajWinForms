using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StajWinForms_API.Models;
using StajWinForms_API.Dtos;

namespace StajWinForms_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FirmalarController : ControllerBase
{
    private readonly DbStajContext _context;

    public FirmalarController(DbStajContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Firmalar>>> GetFirmalar()
    {
        var firmalar = await _context.Firmalars
            .Select(f => new FirmaDto { FirmaId = f.FirmaId, FirmaAdi = f.FirmaAdi })
            .ToListAsync();
        return Ok(firmalar);
    }

    [HttpPost]
    public async Task<ActionResult<Firmalar>> FirmaEkle([FromBody] FirmaDto dto)
    {
        var firma = new Firmalar { FirmaAdi = dto.FirmaAdi };
        _context.Firmalars.Add(firma);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetFirmalar), new { id = firma.FirmaId },
            new FirmaDto { FirmaId = firma.FirmaId, FirmaAdi = firma.FirmaAdi });
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> FirmaGuncelle(int id, [FromBody] FirmaDto dto)
    {
        var firma = await _context.Firmalars.FindAsync(id);
        if (firma == null) return NotFound();

        firma.FirmaAdi = dto.FirmaAdi;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> FirmaSil(int id)
    {
        var firma = await _context.Firmalars.FindAsync(id);
        if (firma == null) return NotFound();

        if (await _context.Seferlers.AnyAsync(s => s.FirmaId == id))
            return BadRequest("Bu firmaya ait seferler mevcut. Önce seferleri silin.");

        if (await _context.Otobuslers.AnyAsync(o => o.FirmaId == id))
            return BadRequest("Bu firmaya atanmış otobüsler mevcut. Önce eşlemeleri kaldırın.");

        _context.Firmalars.Remove(firma);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
