using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StajWinForms_API.Dtos;
using StajWinForms_API.Models;

namespace StajWinForms_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OtobusKaptanController : ControllerBase
{
    private readonly DbStajContext _context;

    public OtobusKaptanController(DbStajContext context)
    {
        _context = context;
    }

    [HttpGet("{otobusId}")]
    public async Task<ActionResult<IEnumerable<OtobusKaptanDto>>> GetKaptanlar(int otobusId)
    {
        var kaptanlar = await _context.OtobusKaptanlar
            .Include(ok => ok.Personel)
            .Where(ok => ok.OtobusId == otobusId)
            .Select(ok => new OtobusKaptanDto
            {
                Id = ok.Id,
                OtobusId = ok.OtobusId,
                PersonelId = ok.PersonelId,
                PersonelAdSoyad = ok.Personel.Ad + " " + ok.Personel.Soyad
            })
            .ToListAsync();

        return Ok(kaptanlar);
    }

    [HttpPost]
    public async Task<IActionResult> KaptanAta([FromBody] OtobusKaptanDto dto)
    {
        if (!await _context.Otobuslers.AnyAsync(o => o.OtobusId == dto.OtobusId))
            return BadRequest("Otobüs bulunamadı.");

        if (!await _context.Personels.AnyAsync(p => p.Id == dto.PersonelId))
            return BadRequest("Personel bulunamadı.");

        if (await _context.OtobusKaptanlar.AnyAsync(ok => ok.OtobusId == dto.OtobusId && ok.PersonelId == dto.PersonelId))
            return Conflict("Bu kaptan zaten bu otobüse atanmış.");

        var atama = new OtobusKaptan
        {
            OtobusId = dto.OtobusId,
            PersonelId = dto.PersonelId
        };

        _context.OtobusKaptanlar.Add(atama);
        await _context.SaveChangesAsync();
        return Ok(new { atama.Id });
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> KaptanKaldir(int id)
    {
        var atama = await _context.OtobusKaptanlar.FindAsync(id);
        if (atama == null) return NotFound();

        _context.OtobusKaptanlar.Remove(atama);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
