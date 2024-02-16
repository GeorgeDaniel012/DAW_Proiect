using AutoMapper;
using daw_proiect.Entities;
using daw_proiect.Models;
using daw_proiect.Repositories;

namespace daw_proiect.Services
{
    public class ComandaService : IComandaService
    {
        private readonly IComandaRepository _comandaRepo;
        private readonly IMapper _mapper;

        public ComandaService(IComandaRepository comandaRepo, IMapper mapper)
        {
            _comandaRepo = comandaRepo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Comanda>> GetComenziAsync()
        {
            return await _comandaRepo.GetComenziAsync();
        }

        public async Task<Comanda> GetComandaAsync(int id)
        {
            return await _comandaRepo.GetComandaAsync(id);
        }

        public async Task<Comanda> AddComandaAsync(PostPutComandaDTO comandaDTO)
        {
            var comanda = _mapper.Map<Comanda>(comandaDTO);
            comanda.DataComanda = DateTime.Now;

            //if this doesn't work I'm gonna use lists instead of ICollections
            foreach (int prodcom in comanda.ProduseId)
            {
                comanda.Produse.Add(new ProdusComanda()
                {
                    ProdusId = prodcom,
                    ComandaId = comanda.Id
                });
            }

            await _comandaRepo.AddComandaAsync(comanda);
            return comanda;
        }

        public async Task<Comanda> UpdateComandaAsync(int id, PostPutComandaDTO comandaDTO)
        {
            var comanda = _mapper.Map<Comanda>(comandaDTO);
            await _comandaRepo.UpdateComandaAsync(id, comanda);
            return comanda;
        }

        public async Task<Comanda> DeleteComandaAsync(int id)
        {
            var comanda = await _comandaRepo.GetComandaAsync(id);
            await _comandaRepo.DeleteComandaAsync(id);
            return comanda;
        }
    }
}
