using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StajWinForms_API.Models;
using StajWinForms_API.Dtos;

namespace StajWinForms_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SeferPersonelController : ControllerBase
{
    private readonly DbStajContext _context;

    public SeferPersonelController(DbStajContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<SeferPersonelDto>>> GetAll([FromQuery] int? seferId)
    {
        var query = _context.SeferPersonels.AsQueryable();

        if (seferId.HasValue)
            query = query.Where(sp => sp.SeferId == seferId.Value);

        var list = await query
            .Select(sp => new SeferPersonelDto
            {
                Id = sp.Id,
                SeferId = sp.SeferId,
                PersonelId = sp.PersonelId,
                PersonelAdSoyad = sp.Personel.Ad + " " + sp.Personel.Soyad,
                Rol = sp.Rol
            })
            .ToListAsync();

        return Ok(list);
    }

    [HttpPost]
    public async Task<ActionResult<SeferPersonelDto>> AtaPersonel(AtaPersonelDto dto)
    {
        var seferVar = await _context.Seferlers.AnyAsync(s => s.SeferId == dto.SeferId);
        if (!seferVar) return NotFound("Sefer bulunamadı.");

        var personelVar = await _context.Personels.AnyAsync(p => p.Id == dto.PersonelId);
        if (!personelVar) return NotFound("Personel bulunamadı.");

        var mevcutAtama = await _context.SeferPersonels
            .AnyAsync(sp => sp.SeferId == dto.SeferId && sp.PersonelId == dto.PersonelId);
        if (mevcutAtama) return Conflict("Bu personel bu sefere zaten atanmış.");

        var yeniAtama = new SeferPersonel
        {
            SeferId = dto.SeferId,
            PersonelId = dto.PersonelId,
            Rol = dto.Rol
        };

        _context.SeferPersonels.Add(yeniAtama);
        await _context.SaveChangesAsync();

        var personel = await _context.Personels.FindAsync(dto.PersonelId);

        return CreatedAtAction(nameof(GetAll), new { seferId = dto.SeferId }, new SeferPersonelDto
        {
            Id = yeniAtama.Id,
            SeferId = yeniAtama.SeferId,
            PersonelId = yeniAtama.PersonelId,
            PersonelAdSoyad = personel!.Ad + " " + personel.Soyad,
            Rol = yeniAtama.Rol
        });
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> KaldirPersonel(int id)
    {
        var atama = await _context.SeferPersonels.FindAsync(id);
        if (atama == null) return NotFound();

        _context.SeferPersonels.Remove(atama);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
