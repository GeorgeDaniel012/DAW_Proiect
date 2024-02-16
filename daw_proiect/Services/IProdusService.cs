using daw_proiect.Entities;
using daw_proiect.Models;

namespace daw_proiect.Services
{
    public interface IProdusService
    {
        public Task<IEnumerable<Produs>> GetProduseAsync();
        public Task<Produs> GetProdusAsync(int id);
        public Task<Produs> AddProdusAsync(PostPutProdusDTO produs);
        public Task<Produs> UpdateProdusAsync(int id, PostPutProdusDTO produs);
        public Task<Produs> DeleteProdusAsync(int id);
    }
}
