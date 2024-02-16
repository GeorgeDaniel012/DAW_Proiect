using AutoMapper;
using daw_proiect.Entities;
using daw_proiect.Models;
using daw_proiect.Repositories;
using daw_proiect.Entities;

namespace daw_proiect.Services
{
    public class LocatieService: ILocatieService
    {
        private readonly ILocatieRepository _locatieRepo;
        //private readonly IMapper _mapper;

        public LocatieService(ILocatieRepository locRepo)
        {
            _locatieRepo = locRepo;
           // _mapper = mapper;
        }

        public async Task<IEnumerable<Locatie>> GetLocatieAsync()
        {
            return await _locatieRepo.GetLocatieAsync();
        }

        public async Task<Locatie> GetLocatieAsync(int id)
        {
            return await _locatieRepo.GetLocatieAsync(id);
        }

        public async Task<Locatie> PutLocatieAsync(Locatie loc)
        {
            //var locatie = _mapper.Map<Client>(clientDTO);
            await _locatieRepo.PutLocatieAsync(loc);
            //await _clientRepo.SaveAsync();
            return loc;
        }

        /*
        public async Task<Client> UpdateClientAsync(int id, PostPutClientDTO clientDTO)
        {
            var client = _mapper.Map<Client>(clientDTO);
            await _clientRepo.UpdateClientAsync(id, client);
            return client;
        }*/

        public async Task<Locatie> DeleteLocatieAsync(int id)
        {
            var locatie = await _locatieRepo.GetLocatieAsync(id);
            await _locatieRepo.DeleteLocatieAsync(id);
            return locatie;
        }

       
    }
}
