using daw_proiect.Entities;

namespace daw_proiect.Repositories
{
    public interface ILocatieRepository
    {

        public Task<IEnumerable<Locatie>> GetLocatieAsync();
        public Task<Locatie> GetLocatieAsync(int id);
        public Task<Locatie> PutLocatieAsync(Locatie locatie);
        public Task<Locatie> DeleteLocatieAsync(int id);
        public Task UpdateLocatieAsync(int id, Locatie locatie);
    }
}
