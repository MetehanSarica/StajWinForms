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
        [FromQuery] int sayfa = 1,
        [FromQuery] int sayfaBoyutu = 50)
    {
        if (sayfa < 1) sayfa = 1;
        if (sayfaBoyutu < 1 || sayfaBoyutu > 100) sayfaBoyutu = 50;

        var musteriler = await _context.Musteris
            .OrderBy(m => m.Id)
            .Skip((sayfa - 1) * sayfaBoyutu)
            .Take(sayfaBoyutu)
            .Select(m => new MusteriDto(m.Id, m.Ad, m.Soyad, m.Sehir, m.Cinsiyet, m.KayitTarihi))
            .ToListAsync();

        return Ok(musteriler);
    }
}