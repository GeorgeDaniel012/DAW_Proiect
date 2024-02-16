using daw_proiect.Entities;

namespace daw_proiect.Repositories
{
    public interface IProdusRepository
    {
        public Task<IEnumerable<Produs>> GetProduseAsync();
        public Task<Produs> GetProdusAsync(int id);
        public Task AddProdusAsync(Produs produs);
        public Task UpdateProdusAsync(int id, Produs produs);
        public Task DeleteProdusAsync(int id);
        public Task SaveAsync();
    }
}
