using AutoMapper;
using daw_proiect.Entities;
using daw_proiect.Models;
using daw_proiect.Repositories;

namespace daw_proiect.Services
{
    public class RecenzieService : IRecenzieService
    {
        private readonly IRecenzieRepository _recenzieRepo;
        private readonly IMapper _mapper;

        public RecenzieService(IMapper mapper, IRecenzieRepository recRepo)
        {
            _recenzieRepo = recRepo;
            _mapper = mapper;
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
        public async Task<Recenzie> UpdateRecenzieAsync(int id, RecenzieDto rec)
        {
            var recenzie = _mapper.Map<Recenzie>(rec);
            await _recenzieRepo.UpdateRecenzieAsync(id, recenzie);
            return recenzie;
        }



    }
}
