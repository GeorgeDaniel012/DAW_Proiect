using daw_proiect.Entities;
using daw_proiect.ContextModels;
using Microsoft.EntityFrameworkCore;

namespace daw_proiect.Repositories
{
    public class ComandaRepository : IComandaRepository
    {
        private readonly Context _context;

        public ComandaRepository(Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Comanda>> GetComenziAsync()
        {
            /*            return await _context.Comanda.Include(com => com.Produse).Join(
                            _context.Produs,
                            com => com.Produse.ProdusId,
                            prod => prod.Id,
                            (com, prod) => new { com, prod }
                            ).ToListAsync();*/

            // folosim un Include si un ThenInclude pentru a returna si produsele
            // care fac parte din comanda
            return await _context.Comanda.Include(com => com.Produse)
                .ThenInclude(prodcom => prodcom.Produs).ToListAsync();
        }

        public async Task<Comanda> GetComandaAsync(int id)
        {
            return await _context.Comanda.Include(com => com.Produse)
                .ThenInclude(prodcom => prodcom.Produs).FirstOrDefaultAsync(prod => prod.Id == id);
        }

        public async Task AddComandaAsync(Comanda comanda)
        {
            _context.Comanda.Add(comanda);

            //trebuie sa adaugam inregistrari in tabelul ProdusComanda cand creem o comanda
/*            foreach (comanda.Produse)
            {
                var prodcom = new 
            }*/

            await _context.SaveChangesAsync();
        }

        public async Task UpdateComandaAsync(int id, Comanda comanda)
        {
            var comandaToUpdate = await _context.Comanda.FirstOrDefaultAsync(prod => prod.Id == id);
            if (comandaToUpdate != null) comanda.Id = comandaToUpdate.Id;
            _context.Comanda.Entry(comandaToUpdate).CurrentValues.SetValues(comanda);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteComandaAsync(int id)
        {
            var comandaToDelete = await _context.Comanda.FirstOrDefaultAsync(prod => prod.Id == id);
            _context.Comanda.Remove(comandaToDelete);

            //stergem toate inregistrarile din ProdusComanda asociate comenzii sterse
            var produsComanda = await _context.ProduseComenzi.Where(prodcom => prodcom.ComandaId == id).ToListAsync();
            foreach(var prodcom in produsComanda)
            {
                _context.ProduseComenzi.Remove(prodcom);
            }

            await _context.SaveChangesAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
