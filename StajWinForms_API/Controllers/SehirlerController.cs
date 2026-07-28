using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StajWinForms_API.Models;
using StajWinForms_API.Dtos;

namespace StajWinForms_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SehirlerController : ControllerBase
{
    private readonly DbStajContext _context;

    public SehirlerController(DbStajContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<SehirDto>>> GetSehirler()
    {
        var sehirler = await _context.Sehirlers
            .Select(s => new SehirDto { SehirId = s.SehirId, SehirAdi = s.SehirAdi,})
            .ToListAsync();
        return Ok(sehirler);
    }
}