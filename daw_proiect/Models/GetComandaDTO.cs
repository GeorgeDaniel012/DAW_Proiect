using daw_proiect.Entities;

namespace daw_proiect.Models
{
    public class GetComandaDTO
    {
        public int Id { get; set; }
        public ICollection<ProdusComanda> Produse { get; set; }
        public GetClientDTO Client { get; set; }
        public DateTime DataComanda { get; set; }
        public Stari StareComanda { get; set; }
        public Tip TipComanda { get; set; }
    }
}
