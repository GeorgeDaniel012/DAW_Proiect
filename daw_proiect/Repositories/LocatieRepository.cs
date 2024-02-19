using daw_proiect.Repositories;
using Microsoft.EntityFrameworkCore;
using daw_proiect.ContextModels;
using daw_proiect.Entities;
using System.Drawing;

namespace daw_proiect.Repositories
{
    public class LocatieRepository : ILocatieRepository
    {

        private readonly Context _locatieContext;

        public LocatieRepository(Context locatie)
        {
            this._locatieContext = locatie;
        }
        public async Task<IEnumerable<Locatie>> GetLocatieAsync()
        {
            return await _locatieContext.Locatie.ToListAsync();

        }
        public async Task<Locatie> GetLocatieAsync(int id)
        {

            return await _locatieContext.Locatie.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<Locatie> PutLocatieAsync(Locatie locatie)
        {
            if (locatie == null)
            {
                throw new ArgumentNullException(nameof(locatie));
            }

            _locatieContext.Set<Locatie>().Add(locatie);
            await _locatieContext.SaveChangesAsync();

            return locatie;
        }

        public async Task<Locatie> DeleteLocatieAsync(int id)
        {
            var locatie = await _locatieContext.Locatie.FindAsync(id);
            if (locatie != null)
            {
                _locatieContext.Locatie.Remove(locatie);
                await _locatieContext.SaveChangesAsync();
            }
            return locatie;
        }
        public async Task UpdateLocatieAsync(int id, Locatie locatie)
        {
            var locatieToUpdate = await _locatieContext.Locatie.FirstOrDefaultAsync(loc => loc.Id == id);
            if (locatieToUpdate != null) locatie.Id = locatieToUpdate.Id;
            _locatieContext.Locatie.Entry(locatieToUpdate).CurrentValues.SetValues(locatie);
            await _locatieContext.SaveChangesAsync();
        }

    }
}
