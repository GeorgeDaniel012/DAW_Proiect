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
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            this._clientService = clientService;
        }

        [HttpGet]
        public async Task<IActionResult> GetClients()
        {
            return Ok(await _clientService.GetClientsAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetClient(int id)
        {
            return Ok(await _clientService.GetClientAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddClient(PostPutClientDTO clientDTO)
        {
            return Ok(await _clientService.AddClientAsync(clientDTO));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateClient(int id, PostPutClientDTO clientDTO)
        {
            return Ok(await _clientService.UpdateClientAsync(id, clientDTO));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClient(int id)
        {
            return Ok(await _clientService.DeleteClientAsync(id));
        }
    }
}
