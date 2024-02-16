using daw_proiect.Entities;
using daw_proiect.Models;

namespace daw_proiect.Services
{
    public interface IClientService
    {
        public Task<IEnumerable<Client>> GetClientsAsync();
        public Task<Client> GetClientAsync(int id);
        public Task<Client> AddClientAsync(PostPutClientDTO client);
        public Task<Client> UpdateClientAsync(int id, PostPutClientDTO client);
        public Task<Client> DeleteClientAsync(int id);
    }
}
