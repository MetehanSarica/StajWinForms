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
}