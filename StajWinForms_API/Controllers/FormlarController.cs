using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StajWinForms_API.Dtos;
using StajWinForms_API.Models;

namespace StajWinForms_API.Controllers;

[ApiController]
[Route("api/[controller]")]

public class FormlarController : ControllerBase
{
    private readonly DbStajContext _context;

    public FormlarController(DbStajContext context)
    {
        _context = context;
    }

    [HttpPost("sync")]
    public async Task<IActionResult> Sync([FromBody] List<FormSyncDto> formlar)
    {
        foreach (var dto in formlar)
        {
            var mevcut = await _context.Formlar
                .FirstOrDefaultAsync(f => f.FormAdi == dto.FormAdi);

            if (mevcut == null)
                _context.Formlar.Add(new Formlar
                {
                    FormAdi = dto.FormAdi,
                    FormAciklamasi = dto.FormAciklamasi
                });
            else
                mevcut.FormAciklamasi = dto.FormAciklamasi;
        }

        await _context.SaveChangesAsync();
        return NoContent();
    }
}