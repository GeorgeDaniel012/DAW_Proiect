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
    public class ComandaController : ControllerBase
    {
        private readonly IComandaService _comandaService;

        public ComandaController(IComandaService comandaService)
        {
            this._comandaService = comandaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetComenzi()
        {
            return Ok(await _comandaService.GetComenziAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetComanda(int id)
        {
            return Ok(await _comandaService.GetComandaAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddComanda(PostPutComandaDTO comandaDTO)
        {
            return Ok(await _comandaService.AddComandaAsync(comandaDTO));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateComanda(int id, PostPutComandaDTO comandaDTO)
        {
            return Ok(await _comandaService.UpdateComandaAsync(id, comandaDTO));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComanda(int id)
        {
            return Ok(await _comandaService.DeleteComandaAsync(id));
        }
    }
}
