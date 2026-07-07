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
            Fiyat = s.Fiyat
            })
            .ToListAsync();

        return Ok(seferler);
    }
}