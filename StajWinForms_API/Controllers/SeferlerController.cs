using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StajWinForms_API.Models;

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
    public async Task<ActionResult<IEnumerable<Seferler>>> GetSeferler()
    {
        var seferler = await _context.Seferlers.ToListAsync();
        return Ok(seferler);
    }
}