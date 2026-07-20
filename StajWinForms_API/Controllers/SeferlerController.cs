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
                KalkisSehirAdi = s.KalkisSehir.SehirAdi,
                VarisSehirAdi = s.VarisSehir.SehirAdi,
                OtobusId = s.OtobusId,
                OtobusPlaka = s.Otobus != null ? s.Otobus.Plaka : null
            })
            .ToListAsync();

        return Ok(seferler);
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

    [HttpDelete("{id}/otobus")]
    public async Task<IActionResult> OtobusKaldir(int id)
    {
        var sefer = await _context.Seferlers.FindAsync(id);
        if (sefer == null) return NotFound();

        sefer.OtobusId = null;
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
