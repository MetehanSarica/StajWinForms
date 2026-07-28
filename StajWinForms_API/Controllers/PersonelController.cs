using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StajWinForms_API.Models;

namespace StajWinForms_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonelController : ControllerBase
{
    private readonly DbStajContext _context;

    public PersonelController(DbStajContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Personel>>> GetPersonel()
    {
        var personel = await _context.Personels.ToListAsync();
        return Ok(personel);
    }

    [HttpPost]
    public async Task<ActionResult<Personel>> PersonelEkle([FromBody] Personel personel)
    {
        personel.Id = 0;
        _context.Personels.Add(personel);
        
        try 
        { 
            await _context.SaveChangesAsync();
        }

        catch (DbUpdateException) 
        {
            return Conflict("Bu email adresi zaten kayıtlı.");
        }
        return CreatedAtAction(nameof(GetPersonel), new { id = personel.Id }, personel);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PersonelGuncelle(int id, [FromBody] Personel dto)
    {
        var personel = await _context.Personels.FindAsync(id);
        if (personel == null) return NotFound();

        personel.Ad = dto.Ad;
        personel.Soyad = dto.Soyad;
        personel.Email = dto.Email;
        personel.Maas = dto.Maas;
        personel.IseGirisTarihi = dto.IseGirisTarihi;

        try
        {
            await _context.SaveChangesAsync();
        }

        catch (DbUpdateException)
        {
            return Conflict("Bu email adresi zaten kayıtlı.");
        }
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> PersonelSil(int id)
    {
        var personel = await _context.Personels.FindAsync(id);
        if (personel == null) return NotFound();

        if (await _context.SeferPersonels.AnyAsync(sp => sp.PersonelId == id))
            return BadRequest("Bu personel seferlere atanmış durumda. Önce sefer atamalarını kaldırın.");

        _context.Personels.Remove(personel);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
