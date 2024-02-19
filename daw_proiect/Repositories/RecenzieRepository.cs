using daw_proiect.ContextModels;
using daw_proiect.Entities;
using daw_proiect.Models;
using Microsoft.EntityFrameworkCore;

namespace daw_proiect.Repositories
{
    public class RecenzieRepository: IRecenzieRepository
    {
       
            private readonly Context _recenzieContext;

            public RecenzieRepository(Context recenzie)
            {
                this._recenzieContext = recenzie;
            }
            public async Task<IEnumerable<Recenzie>> GetRecenzieAsync()
            {
                return await _recenzieContext.Recenzie.ToListAsync();

            }
            public async Task<Recenzie> GetRecenzieAsync(int id)
            {

                return await _recenzieContext.Recenzie.FirstOrDefaultAsync(r => r.Id == id);
            }

            public async Task<Recenzie> PutRecenzieAsync(Recenzie recenzie)
            {
                if (recenzie == null)
                {
                    throw new ArgumentNullException(nameof(recenzie));
                }

                _recenzieContext.Set<Recenzie>().Add(recenzie);
                await _recenzieContext.SaveChangesAsync();

                return recenzie;
            }

            public async Task<Recenzie> DeleteRecenzieAsync(int id)
            {
                var r = await _recenzieContext.Recenzie.FindAsync(id);
                if (r != null)
                {
                    _recenzieContext.Recenzie.Remove(r);
                    await _recenzieContext.SaveChangesAsync();
                }
                return r;
            }

        public async Task UpdateRecenzieAsync(int id, Recenzie recenzie)
        {
            var rec = await _recenzieContext.Recenzie.FirstOrDefaultAsync(r => r.Id == id);
            if (rec != null) recenzie.Id = rec.Id;
            _recenzieContext.Recenzie.Entry(rec).CurrentValues.SetValues(recenzie);
            await _recenzieContext.SaveChangesAsync();
        }


    }
}


