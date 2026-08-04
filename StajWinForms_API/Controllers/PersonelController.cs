using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StajWinForms_API.Dtos;
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
    public async Task<ActionResult<IEnumerable<PersonelDto>>> GetPersonel()
    {
        var personel = await _context.Personels
            .Select(p => new PersonelDto
            {
                Id = p.Id,
                Ad = p.Ad,
                Soyad = p.Soyad,
                Email = p.Email,
                Unvan = p.Unvan,
                Maas = p.Maas,
                IseGirisTarihi = p.IseGirisTarihi
            })
            .ToListAsync();
        return Ok(personel);
    }

    [HttpPost]
    public async Task<ActionResult<PersonelDto>> PersonelEkle([FromBody] PersonelDto dto)
    {
        var personel = new Personel
        {
            Id = 0,
            Ad = dto.Ad,
            Soyad = dto.Soyad,
            Email = dto.Email,
            Unvan = dto.Unvan,
            Maas = dto.Maas,
            IseGirisTarihi = dto.IseGirisTarihi
        };
        _context.Personels.Add(personel);
        
        try 
        { 
            await _context.SaveChangesAsync();
        }

        catch (DbUpdateException) 
        {
            return Conflict("Bu email adresi zaten kayıtlı.");
        }
        return CreatedAtAction(nameof(GetPersonel), new { id = personel.Id }, new PersonelDto
        {
            Id = personel.Id,
            Ad = personel.Ad,
            Soyad = personel.Soyad,
            Email = personel.Email,
            Unvan = personel.Unvan,
            Maas = personel.Maas,
            IseGirisTarihi = personel.IseGirisTarihi
        });
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PersonelGuncelle(int id, [FromBody] PersonelDto dto)
    {
        var personel = await _context.Personels.FindAsync(id);
        if (personel == null) return NotFound();

        personel.Ad = dto.Ad;
        personel.Soyad = dto.Soyad;
        personel.Email = dto.Email;
        personel.Unvan = dto.Unvan;
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
