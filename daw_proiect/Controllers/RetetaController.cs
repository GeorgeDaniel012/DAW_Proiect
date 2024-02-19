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
    public class RetetaController : ControllerBase
    {
        private readonly Context _retetaContext;
        private readonly IRetetaService _repo;
        public RetetaController(Context reteta, IRetetaService service)
        {
            this._retetaContext = reteta;
            this._repo = service;
        }

        //[EnableCors("AnotherPolicy")]
        [HttpGet]
        public async Task<IActionResult> GetReteta()
        {
            return Ok(await _repo.GetRetetaAsync());
        }

        [EnableCors("AnotherPolicy")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetReteta(int id)
        {
            var r = await _repo.GetRetetaAsync(id);
            if (r == null)
                return NotFound();
            return Ok(r);
        }

        [HttpPost]
        public async Task<ActionResult<Reteta>> PostReteta(RetetaDto r)
        {
            var reteta = new Reteta()
            {
                ProdusId = r.ProdusId,
                Indicatii = r.Indicatii
            };
            var createdReteta = await _repo.PutRetetaAsync(reteta);
            return CreatedAtAction(nameof(GetReteta), new { id = createdReteta.ProdusId }, createdReteta);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateReteta(int id, RetetaDto reteta)
        {
            return Ok(await _repo.UpdateRetetaAsync(id, reteta));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReteta(int id)
        {
            var reteta = await _repo.DeleteRetetaAsync(id);
            if (reteta != null)
            {
                return Ok(reteta);
            }
            return NotFound();
        }
    }

}
