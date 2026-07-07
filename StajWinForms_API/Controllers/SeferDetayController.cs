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
    public async Task<ActionResult<IEnumerable<SeferDetayDto>>> GetSeferDetay()
    {
        var seferDetay = await _context.SeferDetays
            .Select(s => new SeferDetayDto
            {
                FirmaAdi = s.Firma.FirmaAdi,
                KalkisSehirAdi = s.KalkisSehir.SehirAdi,
                VarisSehirAdi = s.VarisSehir.SehirAdi,
                KalkisZamani = s.KalkisZamani,
                Fiyat = s.Fiyat,
                BosKoltuk = s.BosKoltuk
            }).ToListAsync();

        return Ok(seferDetay);
    }
}