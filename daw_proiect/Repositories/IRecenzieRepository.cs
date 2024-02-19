using daw_proiect.Entities;

namespace daw_proiect.Repositories
{
    public interface IRecenzieRepository
    {
        public Task<IEnumerable<Recenzie>> GetRecenzieAsync();
        public Task<Recenzie> GetRecenzieAsync(int id);
        public Task<Recenzie> PutRecenzieAsync(Recenzie recenzie);
        public Task UpdateRecenzieAsync(int id, Recenzie recenzie);
        public Task<Recenzie> DeleteRecenzieAsync(int id);
    }
}
