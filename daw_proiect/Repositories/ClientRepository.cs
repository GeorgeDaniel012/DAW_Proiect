using daw_proiect.Entities;
using daw_proiect.ContextModels;
using Microsoft.EntityFrameworkCore;

namespace daw_proiect.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly Context _context;

        public ClientRepository(Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Client>> GetClientsAsync()
        {
            return await _context.Client.ToListAsync();
        }

        public async Task<Client> GetClientAsync(int id)
        {
            return await _context.Client.FirstOrDefaultAsync(cli => cli.Id == id);
        }

        public async Task AddClientAsync(Client client)
        {
            _context.Client.Add(client);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateClientAsync(int id, Client client)
        {
            var clientToUpdate = await _context.Client.FirstOrDefaultAsync(cli => cli.Id == id);
            _context.Client.Entry(clientToUpdate).CurrentValues.SetValues(client);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteClientAsync(int id)
        {
            var clientToDelete = await _context.Client.FirstOrDefaultAsync(cli => cli.Id == id);
            _context.Client.Remove(clientToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
