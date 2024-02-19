using daw_proiect.Entities;
using daw_proiect.Models;

namespace daw_proiect.Services
{
    public interface ILocatieService
    {
        public Task<IEnumerable<Locatie>> GetLocatieAsync();
        public Task<Locatie> GetLocatieAsync(int id);
        public Task<Locatie> PutLocatieAsync(Locatie locatie);
        public Task<Locatie> DeleteLocatieAsync(int id);
        public Task<Locatie> UpdateLocatieAsync(int id, LocatieDto locatie);
    }
}
