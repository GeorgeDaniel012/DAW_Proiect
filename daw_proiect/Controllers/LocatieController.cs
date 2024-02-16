using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using daw_proiect.ContextModels;
using ProiectASP.Entities;
using ProiectASP.Repositories;
using System.Drawing;
using daw_proiect.Models;
using daw_proiect.Models;
using daw_proiect.Repositories;

namespace ProiectASP.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class LocatieController : ControllerBase
    {
        private readonly Context _locatieContext;
        private readonly ILocatieRepository _repo;
        public LocatieController(Context locatie, ILocatieRepository repo)
        {
            this._locatieContext = locatie;
            this._repo = repo;
        }
        //[EnableCors("AnotherPolicy")]
        [HttpGet]

        public async Task<IEnumerable<Locatie>> GetLocatie()
        {
            return await _repo.GetLocatieAsync();
        }

        [EnableCors("AnotherPolicy")]
        [HttpGet("{id}")]

        public async Task<IActionResult> GetLocatie(int id)
        {
            var l = await _repo.GetLocatieAsync(id);
            if (l == null)
                return NotFound();
            return Ok(l);

        }

        [HttpPost]
        public async Task<ActionResult<Locatie>> PostLocatie(LocatieDto l)
        {
            var loc = new Locatie()
            {
                Oras = l.Oras,
                Strada = l.Strada,
                Numar_cladire = l.Numar_cladire
            };
            var createdLocatie = await _repo.PutLocatieAsync(loc);
            return CreatedAtAction(nameof(GetLocatie), new { id = createdLocatie.Id }, createdLocatie);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLocatie(int id)
        {
            var loc = await _repo.DeleteLocatieAsync(id);
            if (loc != null)
            {
                return Ok(loc);
            }
            return NotFound();
        }

    }
}
