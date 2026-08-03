using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StajWinForms_API.Dtos;
using StajWinForms_API.Models;

namespace StajWinForms_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OtogarlarController : ControllerBase
    {
        private readonly DbStajContext _context;

        public OtogarlarController(DbStajContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<OtogarDto>>> GetAll([FromQuery] int? sehirId)
        {
            var query = _context.Otogarlars.AsQueryable();
            if (sehirId.HasValue)
                query = query.Where(o => o.SehirId == sehirId.Value);

            var list = await query
                .Select(o => new OtogarDto
                {
                    OtogarId = o.OtogarId,
                    SehirId = o.SehirId,
                    SehirAdi = o.Sehir.SehirAdi,
                    OtogarAdi = o.OtogarAdi,
                    Adres = o.Adres,
                    Telefon = o.Telefon
                })
                .OrderBy(o => o.SehirAdi).ThenBy(o => o.OtogarAdi)
                .ToListAsync();

            return Ok(list);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] OtogarCreateDto dto)
        {
            var otogar = new Otogarlar
            {
                SehirId = dto.SehirId,
                OtogarAdi = dto.OtogarAdi,
                Adres = dto.Adres,
                Telefon = dto.Telefon
            };
            _context.Otogarlars.Add(otogar);
            await _context.SaveChangesAsync();
            return Ok(new { otogar.OtogarId });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] OtogarCreateDto dto)
        {
            var otogar = await _context.Otogarlars.FindAsync(id);
            if (otogar == null) return NotFound();

            otogar.SehirId = dto.SehirId;
            otogar.OtogarAdi = dto.OtogarAdi;
            otogar.Adres = dto.Adres;
            otogar.Telefon = dto.Telefon;
            await _context.SaveChangesAsync();
            return Ok(otogar);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var otogar = await _context.Otogarlars.FindAsync(id);
            if (otogar == null) return NotFound();

            _context.Otogarlars.Remove(otogar);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}