using daw_proiect.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using daw_proiect.ContextModels;

namespace daw_proiect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly Context _context;

        public ClientController(Context Context)
        {
            this._context = Context;
        }

        [HttpGet]
        public async Task<IActionResult> GetClients()
        {
            return Ok(await _context.Client.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetClient(int id)
        {
            var _client = await _context.Client.Select(cli => new Client()
            {
                Id = cli.Id,
                Nume = cli.Nume,
                Prenume = cli.Prenume,
                Email = cli.Email,
                Comenzi = cli.Comenzi,
                AdresaPrincipala = cli.AdresaPrincipala,
            }).SingleOrDefaultAsync(cli => cli.Id == id);
            if (_client == null)
            {
                return NotFound();
            }
            return Ok(_client);
        }

        [HttpPost]
        public async Task<ActionResult<Client>> PostUser(string Nume, string Prenume, string Email)
        {
            var _user = new Client()
            {
                Nume = Nume,
                Prenume = Prenume,
                Email = Email
            };

            _context.Client.Add(_user);
            _context.SaveChanges();
            return Ok(_user);
        }


    }
}
