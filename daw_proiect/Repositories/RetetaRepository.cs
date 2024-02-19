using daw_proiect.ContextModels;
using daw_proiect.Entities;
using Microsoft.EntityFrameworkCore;

namespace daw_proiect.Repositories
{
    public class RetetaRepository : IRetetaRepository
    {
        private readonly Context _retetaContext;

        public RetetaRepository(Context reteta)
        {
            this._retetaContext = reteta;
        }
        public async Task<IEnumerable<Reteta>> GetRetetaAsync()
        {
            return await _retetaContext.Reteta.ToListAsync();

        }
        public async Task<Reteta> GetRetetaAsync(int id)
        {

            return await _retetaContext.Reteta.FirstOrDefaultAsync(r => r.ProdusId == id);
        }

        public async Task<Reteta> PutRetetaAsync(Reteta reteta)
        {
            if (reteta == null)
            {
                throw new ArgumentNullException(nameof(reteta));
            }

            _retetaContext.Set<Reteta>().Add(reteta);
            await _retetaContext.SaveChangesAsync();

            return reteta;
        }

        public async Task<Reteta> DeleteRetetaAsync(int id)
        {
            var r = await _retetaContext.Reteta.FindAsync(id);
            if (r != null)
            {
                _retetaContext.Reteta.Remove(r);
                await _retetaContext.SaveChangesAsync();
            }
            return r;
        }

        public async Task UpdateRetetaAsync(int id, Reteta reteta)
        {
            var ret = await _retetaContext.Reteta.FirstOrDefaultAsync(r => r.ProdusId == id);
            if (ret != null) reteta.ProdusId = ret.ProdusId;
            _retetaContext.Reteta.Entry(ret).CurrentValues.SetValues(reteta);
            await _retetaContext.SaveChangesAsync();
        }


    }
}
