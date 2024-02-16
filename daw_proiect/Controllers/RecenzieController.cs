using daw_proiect.ContextModels;
using daw_proiect.Entities;
using daw_proiect.Models;
using daw_proiect.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace daw_proiect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecenzieController : ControllerBase
    {
        private readonly Context _recenzieContext;
        private readonly IRecenzieService _recenzieService;
        public RecenzieController(Context recenzie, IRecenzieService service)
        {
            this._recenzieContext = recenzie;
            this._recenzieService = service;
        }
        //[EnableCors("AnotherPolicy")]
        [HttpGet]

        public async Task<IActionResult> GetRecenzie()
        {
            return Ok(await _recenzieService.GetRecenzieAsync());
        }

        [EnableCors("AnotherPolicy")]
        [HttpGet("{id}")]

        public async Task<IActionResult> GetRecenzie(int id)
        {
            var l = await _recenzieService.GetRecenzieAsync(id);
            if (l == null)
                return NotFound();
            return Ok(l);

        }

        [HttpPost]
        public async Task<ActionResult<Recenzie>> PostRecenzie(RecenzieDto r)
        {
            var rec = new Recenzie()
            {
                Nota = r.Nota,
                Comentariu = r.Comentariu,
                ClientId = r.ClientId,
                ProdusId = r.ProdusId
            };
            var createdRecenzie = await _recenzieService.PutRecenzieAsync(rec);
            return CreatedAtAction(nameof(GetRecenzie), new { id = createdRecenzie.Id }, createdRecenzie);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecenzie(int id)
        {
            var loc = await _recenzieService.DeleteRecenzieAsync(id);
            if (loc != null)
            {
                return Ok(loc);
            }
            return NotFound();
        }

    }
}
