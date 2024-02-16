using daw_proiect.Entities;

namespace daw_proiect.Repositories
{
    public interface IComandaRepository
    {
        public Task<IEnumerable<Comanda>> GetComenziAsync();
        public Task<Comanda> GetComandaAsync(int id);
        public Task AddComandaAsync(Comanda comanda);
        public Task UpdateComandaAsync(int id, Comanda comanda);
        public Task DeleteComandaAsync(int id);
        public Task SaveAsync();
    }
}
