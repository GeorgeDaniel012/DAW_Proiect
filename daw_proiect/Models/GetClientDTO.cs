using daw_proiect.Entities;

namespace daw_proiect.Models
{
    public class GetClientDTO
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Email { get; set; }
        //pentru include:
        public ICollection<GetComandaDTO> Comenzi { get; set; }
        public AdresaPrincipala? AdresaPrincipala { get; set; }
    }
}
