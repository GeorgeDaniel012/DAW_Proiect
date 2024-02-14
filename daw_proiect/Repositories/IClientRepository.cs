using daw_proiect.Entities;

namespace daw_proiect.Repositories
{
    public interface IClientRepository
    {
        public Task<IEnumerable<Client>> GetClientsAsync();
        public Task<Client> GetClientAsync(int id);
        public Task AddClientAsync(Client client);
        public Task UpdateClientAsync(int id, Client client);
        public Task DeleteClientAsync(int id);
        public Task SaveAsync();
    }
}
