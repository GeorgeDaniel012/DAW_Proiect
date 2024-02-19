using AutoMapper;
using daw_proiect.Entities;
using daw_proiect.Models;
using daw_proiect.Repositories;

namespace daw_proiect.Services
{
    public class RetetaService : IRetetaService
    {
        private readonly IRetetaRepository _retetaRepo;
        private readonly IMapper _mapper;

        public RetetaService(IRetetaRepository Repo, IMapper mapper)
        {
            _retetaRepo = Repo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Reteta>> GetRetetaAsync()
        {
            return await _retetaRepo.GetRetetaAsync();
        }

        public async Task<Reteta> GetRetetaAsync(int id)
        {
            return await _retetaRepo.GetRetetaAsync(id);
        }

        public async Task<Reteta> PutRetetaAsync(Reteta ret)
        {
            await _retetaRepo.PutRetetaAsync(ret);
            return ret;
        }

        public async Task<Reteta> UpdateRetetaAsync(int id, RetetaDto ret)
        {
            var reteta = _mapper.Map<Reteta>(ret);
            await _retetaRepo.UpdateRetetaAsync(id, reteta);
            return reteta;
        }

        public async Task<Reteta> DeleteRetetaAsync(int id)
        {
            var reteta = await _retetaRepo.GetRetetaAsync(id);
            await _retetaRepo.DeleteRetetaAsync(id);
            return reteta;
        }
    }
}
