using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StajWinForms_API.Models;

namespace StajWinForms_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SeferDuraklarController : ControllerBase
{
    private readonly DbStajContext _context;

    public SeferDuraklarController(DbStajContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<SeferDuraklar>>> GetSeferDuraklar()
    {
        var seferDuraklar = await _context.SeferDuraklars.ToListAsync();
        return Ok(seferDuraklar);
    }

    [HttpGet("{seferId}")]
    public async Task<ActionResult> GetBySeferId(int seferId)
    {
        var duraklar = await _context.SeferDuraklars
            .Where(sd => sd.SeferId == seferId)
            .OrderBy(sd => sd.DurakSira)
            .Select(sd => new { sd.DurakSira, sd.Sehir.SehirAdi })
            .ToListAsync();
        return Ok(duraklar);
    }
}