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
        var yeniFormlar = new List<Formlar>();

        foreach (var dto in formlar)
        {
            var mevcut = await _context.Formlar
                .FirstOrDefaultAsync(f => f.FormAdi == dto.FormAdi);

            if (mevcut == null)
            {
                var yeni = new Formlar { FormAdi = dto.FormAdi, FormAciklamasi = dto.FormAciklamasi };
                _context.Formlar.Add(yeni);
                yeniFormlar.Add(yeni);
            }
            else
                mevcut.FormAciklamasi = dto.FormAciklamasi;
        }

        await _context.SaveChangesAsync();

        if (yeniFormlar.Count > 0)
        {
            var kullaniciIdleri = await _context.Kullanicilars
                .Select(k => k.KullaniciId).ToListAsync();

            foreach (var form in yeniFormlar)
                foreach (var kullaniciId in kullaniciIdleri)
                    _context.KullaniciYetkileri.Add(new KullaniciYetkileri
                    {
                        KullaniciId = kullaniciId,
                        FormId = form.FormId
                    });

            await _context.SaveChangesAsync();
        }

        return NoContent();
    }
}