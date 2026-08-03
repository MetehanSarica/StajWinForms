using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StajWinForms_API.Dtos;
using StajWinForms_API.Models;

namespace StajWinForms_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MusteriController : ControllerBase
{
    private readonly DbStajContext _context;

    public MusteriController(DbStajContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<MusteriDto>>> GetMusteri(
        [FromQuery] string? ara,
        [FromQuery] int sayfa = 1,
        [FromQuery] int sayfaBoyutu = 50)
    {
        if (sayfa < 1) sayfa = 1;
        if (sayfaBoyutu < 1 || sayfaBoyutu > 100) sayfaBoyutu = 50;

        var query = _context.Musteris.AsQueryable();

        if (!string.IsNullOrEmpty(ara))
            query = query.Where(m => m.Tc.Contains(ara) || (m.Ad + " " + m.Soyad).Contains(ara));
        
        var musteriler = await query
            .OrderBy(m => m.Ad).ThenBy(m => m.Soyad)
            .Skip((sayfa - 1) * sayfaBoyutu)
            .Take(sayfaBoyutu)
            .Select(m => new MusteriDto(m.Id, m.Ad, m.Soyad, m.Tc, m.Email, m.Telefon, m.Sehir, m.Cinsiyet, m.KayitTarihi))
            .ToListAsync();

        return Ok(musteriler);
    }

    [HttpGet("{id}/biletler")]
    public async Task<IActionResult> GetBiletler(int id)
    {
        var biletler = await _context.Biletlers
            .Where(b => b.MusteriTcNavigation.Id == id)
            .Select(b => new
            {
                b.BiletId,
                b.KoltukNo,
                KalkisSehir = b.Sefer.KalkisSehir.SehirAdi,
                VarisSehir = b.Sefer.VarisSehir.SehirAdi,
                b.Sefer.KalkisZamani,
                b.Sefer.Fiyat,
                FirmaAdi = b.Sefer.Firma.FirmaAdi
            })
            .OrderByDescending(b => b.KalkisZamani)
            .ToListAsync();

        return Ok(biletler);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var musteri = await _context.Musteris.FindAsync(id);
        if (musteri == null) return NotFound();

        _context.Musteris.Remove(musteri);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}