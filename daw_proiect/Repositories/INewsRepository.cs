using daw_proiect.Entities;
using ProiectASP.Entities;

namespace daw_proiect.Repositories
{
    public interface INewsRepository
    {

        public Task<IEnumerable<Locatie>> GetLocatieAsync();
        public Task<Locatie> GetLocatieAsync(int id);
        public Task<Locatie> PutLocatieAsync(Locatie locatie);
        public Task<Locatie> DeleteLocatieAsync(int id);
    }
}
