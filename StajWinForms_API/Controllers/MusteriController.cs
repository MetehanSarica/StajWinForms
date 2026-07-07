using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    public async Task<ActionResult<IEnumerable<Musteri>>> GetMusteri()
    {
        var musteriler = await _context.Musteris.ToListAsync();
        return Ok(musteriler);
    }
}