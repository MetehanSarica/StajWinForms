using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StajWinForms_API.Models;

namespace StajWinForms_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FirmalarController : ControllerBase
{
    private readonly DbStajContext _context;

    public FirmalarController(DbStajContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Firmalar>>> GetFirmalar()
    {
        var firmalar = await _context.Firmalars.ToListAsync();
        return Ok(firmalar);
    }
}