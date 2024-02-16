using daw_proiect.Entities;
using daw_proiect.Repositories;

namespace daw_proiect.Services
{
    public class RecenzieService : IRecenzieService
    {
        private readonly IRecenzieRepository _recenzieRepo;

        public RecenzieService(IRecenzieRepository recRepo)
        {
            _recenzieRepo = recRepo;
        }

        public async Task<IEnumerable<Recenzie>> GetRecenzieAsync()
        {
            return await _recenzieRepo.GetRecenzieAsync();
        }

        public async Task<Recenzie> GetRecenzieAsync(int id)
        {
            return await _recenzieRepo.GetRecenzieAsync(id);
        }

        public async Task<Recenzie> PutRecenzieAsync(Recenzie r)
        {
            await _recenzieRepo.PutRecenzieAsync(r);
            return r;
        }

        public async Task<Recenzie> DeleteRecenzieAsync(int id)
        {
            var r = await _recenzieRepo.GetRecenzieAsync(id);
            await _recenzieRepo.DeleteRecenzieAsync(id);
            return r;
        }


    
}
}
