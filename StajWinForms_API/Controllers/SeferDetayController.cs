using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StajWinForms_API.Models;
using StajWinForms_API.Dtos;

namespace StajWinForms_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SeferDetayController : ControllerBase
{
    private readonly DbStajContext _context;

    public SeferDetayController(DbStajContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<SeferDetayDto>>> GetSeferDetaylar()
    {
        var list = await _context.Seferlers
            .Select(s => new SeferDetayDto
            {
                SeferId = s.SeferId,
                FirmaAdi = s.Firma.FirmaAdi,
                KalkisSehirAdi = s.KalkisSehir.SehirAdi,
                VarisSehirAdi = s.VarisSehir.SehirAdi,
                KalkisZamani = s.KalkisZamani,
                Fiyat = s.Fiyat,
                BosKoltuk = s.KoltukKapasitesi - s.Biletlers.Count()
            })
            .ToListAsync();

        return Ok(list);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<SeferDetayDto>> GetSeferDetayById(int id)
    {
        var sefer = await _context.Seferlers
            .Where(s => s.SeferId == id)
            .Select(s => new SeferDetayDto
            {
                SeferId = s.SeferId,
                FirmaAdi = s.Firma.FirmaAdi,
                KalkisSehirAdi = s.KalkisSehir.SehirAdi,
                VarisSehirAdi = s.VarisSehir.SehirAdi,
                KalkisZamani = s.KalkisZamani,
                Fiyat = s.Fiyat,
                BosKoltuk = s.KoltukKapasitesi - s.Biletlers.Count(),
                Duraklar = s.SeferDurakOtogars
                    .OrderBy(d => d.DurakSira)
                    .Select(d => d.Otogar.OtogarAdi)
                    .ToList()
            })

            .FirstOrDefaultAsync();

        if (sefer == null) return NotFound();
        return Ok(sefer);
    }
}
