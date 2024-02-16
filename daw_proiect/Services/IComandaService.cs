using daw_proiect.Entities;
using daw_proiect.Models;

namespace daw_proiect.Services
{
    public interface IComandaService
    {
        public Task<IEnumerable<Comanda>> GetComenziAsync();
        public Task<Comanda> GetComandaAsync(int id);
        public Task<Comanda> AddComandaAsync(PostPutComandaDTO comanda);
        public Task<Comanda> UpdateComandaAsync(int id, PostPutComandaDTO comanda);
        public Task<Comanda> DeleteComandaAsync(int id);
    }
}
