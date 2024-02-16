using AutoMapper;
using daw_proiect.Entities;
using daw_proiect.Models;

namespace daw_proiect.Helpers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Client, GetClientDTO>();
            CreateMap<GetClientDTO, Client>();
            CreateMap<Client, PostPutClientDTO>();
            CreateMap<PostPutClientDTO, Client>();
        }
    }
}
