using System.ComponentModel.DataAnnotations.Schema;

namespace daw_proiect.Entities
{
    public enum Stari
    {
        InPregatire = 0,
        Realizata = 1,
        Anulata = 2
    }

    public class Comanda
    {
        public int Id { get; set; }
        public ICollection<ProdusComanda> Produse { get; set; } = new List<ProdusComanda>();
        [NotMapped]
        public List<int> ProduseId { get; set; } = new List<int>();
        public Client Client { get; set; }
        public int ClientId { get; set; }
        public DateTime DataComanda { get; set; }
        public Stari StareComanda { get; set; }
    }
}
