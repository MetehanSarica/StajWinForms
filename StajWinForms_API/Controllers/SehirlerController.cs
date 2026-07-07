using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StajWinForms_API.Models;

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
    public async Task<ActionResult<IEnumerable<Sehirler>>> GetSehirler()
    {
        var sehirler = await _context.Sehirlers.ToListAsync();
        return Ok(sehirler);
    }
}