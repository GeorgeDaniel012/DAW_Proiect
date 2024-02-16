using daw_proiect.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace daw_proiect.Models
{
    public class GetComandaDTO
    {
        public int Id { get; set; }
        //pentru include:
        public ICollection<ProdusComanda> Produse { get; set; } = new List<ProdusComanda>();
        [NotMapped]
        public List<int> ProduseId { get; set; } = new List<int>();
        public Client Client { get; set; }
        public int ClientId { get; set; }
        public DateTime DataComanda { get; set; }
        public Stari StareComanda { get; set; }
    }
}
