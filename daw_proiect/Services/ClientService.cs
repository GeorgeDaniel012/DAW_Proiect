using AutoMapper;
using daw_proiect.Entities;
using daw_proiect.Models;
using daw_proiect.Repositories;

namespace daw_proiect.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepo;
        private readonly IMapper _mapper;

        public ClientService(IClientRepository clientRepo, IMapper mapper) 
        {  
            _clientRepo = clientRepo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Client>> GetClientsAsync()
        {
            return await _clientRepo.GetClientsAsync();
        }

        public async Task<Client> GetClientAsync(int id)
        {
            return await _clientRepo.GetClientAsync(id);
        }

        public async Task<Client> AddClientAsync(PostPutClientDTO clientDTO)
        {
            var client = _mapper.Map<Client>(clientDTO);
            //adaugam o inregistrare noua in AdresaPrincipala pt clientul nou
            client.AdresaPrincipala = new AdresaPrincipala()
            {
                Client = client
            };

            await _clientRepo.AddClientAsync(client);
            await _clientRepo.SaveAsync();
            return client;
        }

        public async Task<Client> UpdateClientAsync(int id, PostPutClientDTO clientDTO)
        {
            var client = _mapper.Map<Client>(clientDTO);
            await _clientRepo.UpdateClientAsync(id, client);
            return client;
        }

        public async Task<Client> DeleteClientAsync(int id)
        {
            var client = await _clientRepo.GetClientAsync(id);
            await _clientRepo.DeleteClientAsync(id);
            return client;
        }
    }
}
