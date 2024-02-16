using daw_proiect.Repositories;
using Microsoft.EntityFrameworkCore;
using daw_proiect.ContextModels;
using ProiectASP.Entities;
using System.Drawing;

namespace ProiectASP.Repositories
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
            return await _locatieContext.Locatii.ToListAsync();

        }
        public async Task<Locatie> GetLocatieAsync(int id)
        {

            return await _locatieContext.Locatii.FirstOrDefaultAsync(s => s.Id == id);
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
            var locatie = await _locatieContext.Locatii.FindAsync(id);
            if (locatie != null)
            {
                _locatieContext.Locatii.Remove(locatie);
                await _locatieContext.SaveChangesAsync();
            }
            return locatie;
        }


    }
}
