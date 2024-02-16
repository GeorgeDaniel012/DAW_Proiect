using daw_proiect.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using daw_proiect.ContextModels;
using daw_proiect.Services;
using daw_proiect.Models;

namespace daw_proiect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdusController : ControllerBase
    {
        private readonly IProdusService _produsService;

        public ProdusController(IProdusService produsService)
        {
            this._produsService = produsService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProduse()
        {
            return Ok(await _produsService.GetProduseAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProdus(int id)
        {
            return Ok(await _produsService.GetProdusAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddProdus(PostPutProdusDTO produsDTO)
        {
            return Ok(await _produsService.AddProdusAsync(produsDTO));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProdus(int id, PostPutProdusDTO produsDTO)
        {
            return Ok(await _produsService.UpdateProdusAsync(id, produsDTO));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProdus(int id)
        {
            return Ok(await _produsService.DeleteProdusAsync(id));
        }
    }
}
