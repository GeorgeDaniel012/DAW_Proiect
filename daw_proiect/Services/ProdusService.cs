using AutoMapper;
using daw_proiect.Entities;
using daw_proiect.Models;
using daw_proiect.Repositories;

namespace daw_proiect.Services
{
    public class ProdusService : IProdusService
    {
        private readonly IProdusRepository _produsRepo;
        private readonly IMapper _mapper;

        public ProdusService(IProdusRepository produsRepo, IMapper mapper)
        {
            _produsRepo = produsRepo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Produs>> GetProduseAsync()
        {
            return await _produsRepo.GetProduseAsync();
        }

        public async Task<Produs> GetProdusAsync(int id)
        {
            return await _produsRepo.GetProdusAsync(id);
        }

        public async Task<Produs> AddProdusAsync(PostPutProdusDTO produsDTO)
        {
            var produs = _mapper.Map<Produs>(produsDTO);

            //adaugam o inregistrare noua in Reteta pt produsul nou
            produs.Reteta = new Reteta()
            {
                Produs = produs,
                Indicatii = ""
            };

            await _produsRepo.AddProdusAsync(produs);
            return produs;
        }

        public async Task<Produs> UpdateProdusAsync(int id, PostPutProdusDTO produsDTO)
        {
            var produs = _mapper.Map<Produs>(produsDTO);
            await _produsRepo.UpdateProdusAsync(id, produs);
            return produs;
        }

        public async Task<Produs> DeleteProdusAsync(int id)
        {
            var produs = await _produsRepo.GetProdusAsync(id);
            await _produsRepo.DeleteProdusAsync(id);
            return produs;
        }
    }
}
