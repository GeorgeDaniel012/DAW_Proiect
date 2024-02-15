using daw_proiect.ContextModels;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using daw_proiect.Entities;
using System.Drawing;
using ProiectASP.Entities;

namespace ProiectASP.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class LocatieController : ControllerBase
    {
        private readonly Context _locatieContext;

        public LocatieController(Context locatie)
        {
            this._locatieContext = locatie;
        }
        //[EnableCors("AnotherPolicy")]
        [HttpGet]

        public async Task<IActionResult> GetLocatie()
        {
            return Ok(await _locatieContext.Locatii.ToListAsync());
        }

        [EnableCors("AnotherPolicy")]
        [HttpGet("{id}")]

        public async Task<IActionResult> GetLocatie(int id)
        {
            var l = await _locatieContext.Locatii.Select(loc => new Locatie()
            {
                Oras = loc.Oras,
                Strada = loc.Strada,
                Numar_cladire = loc.Numar_cladire
            }).SingleOrDefaultAsync(loc => loc.Id == id);


            if (l == null)
                return NotFound();
            return Ok(l);

        }

        [HttpPost]
        public async Task<ActionResult<Locatie>> PostLocatie(Locatie l)
        {
            var loc = new Locatie()
            {
                Oras = l.Oras,
                Strada = l.Strada,
                Numar_cladire = l.Numar_cladire
            };
            await _locatieContext.Locatii.AddAsync(loc);
            await _locatieContext.SaveChangesAsync();
            return CreatedAtAction(nameof(GetLocatie), new { id = loc.Id }, loc);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLocatie(int id)
        {
            var loc = await _locatieContext.Locatii.FindAsync(id);
            if (loc != null)
            {
                _locatieContext.Remove(loc);
                _locatieContext.SaveChanges();
                return Ok(loc);
            }
            return NotFound();
        }
    }
}
