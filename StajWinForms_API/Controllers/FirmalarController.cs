using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StajWinForms_API.Models;

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
        var firmalar = await _context.Firmalars.ToListAsync();
        return Ok(firmalar);
    }

    [HttpPost]
    public async Task<ActionResult<Firmalar>> FirmaEkle([FromBody] Firmalar firma)
    {
        firma.FirmaId = 0;
        _context.Firmalars.Add(firma);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetFirmalar), new { id = firma.FirmaId }, firma);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> FirmaGuncelle(int id, [FromBody] Firmalar dto)
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
