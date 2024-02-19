using daw_proiect.Entities;

namespace daw_proiect.Repositories
{
    public interface IRetetaRepository
    {
        public Task<IEnumerable<Reteta>> GetRetetaAsync();
        public Task<Reteta> GetRetetaAsync(int id);
        public Task<Reteta> PutRetetaAsync(Reteta reteta);
        public Task UpdateRetetaAsync(int id, Reteta reteta);
        public Task<Reteta> DeleteRetetaAsync(int id);
    }
}
