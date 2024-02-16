using daw_proiect.Entities;
using daw_proiect.ContextModels;
using Microsoft.EntityFrameworkCore;

namespace daw_proiect.Repositories
{
    public class ProdusRepository : IProdusRepository
    {
        private readonly Context _context;

        public ProdusRepository(Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Produs>> GetProduseAsync()
        {
            return await _context.Produs.ToListAsync();
        }

        public async Task<Produs> GetProdusAsync(int id)
        {
            return await _context.Produs.FirstOrDefaultAsync(prod => prod.Id == id);
        }

        public async Task AddProdusAsync(Produs produs)
        {
            _context.Produs.Add(produs);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProdusAsync(int id, Produs produs)
        {
            var produsToUpdate = await _context.Produs.FirstOrDefaultAsync(prod => prod.Id == id);
            if (produsToUpdate != null) produs.Id = produsToUpdate.Id;
            _context.Produs.Entry(produsToUpdate).CurrentValues.SetValues(produs);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProdusAsync(int id)
        {
            var produsToDelete = await _context.Produs.FirstOrDefaultAsync(prod => prod.Id == id);
            _context.Produs.Remove(produsToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
