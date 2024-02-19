using daw_proiect.Entities;
using daw_proiect.Models;

namespace daw_proiect.Services
{
    public interface IRetetaService
    {
        public Task<IEnumerable<Reteta>> GetRetetaAsync();
        public Task<Reteta> GetRetetaAsync(int id);
        public Task<Reteta> PutRetetaAsync(Reteta reteta);
        public Task<Reteta> UpdateRetetaAsync(int id, RetetaDto reteta);
        public Task<Reteta> DeleteRetetaAsync(int id);
    }
}
