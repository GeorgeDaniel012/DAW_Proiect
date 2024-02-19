using daw_proiect.Entities;
using daw_proiect.Models;

namespace daw_proiect.Services
{
    public interface IRecenzieService
    {
        public Task<IEnumerable<Recenzie>> GetRecenzieAsync();
        public Task<Recenzie> GetRecenzieAsync(int id);
        public Task<Recenzie> PutRecenzieAsync(Recenzie recenzie);
        public Task<Recenzie> DeleteRecenzieAsync(int id);
        public Task<Recenzie> UpdateRecenzieAsync(int id, RecenzieDto recenzie);
    }
}

