namespace daw_proiect.Entities
{
    public enum Stari
    {
        InPregatire,
        Realizata,
        Anulata
    }

    public enum Tip
    {
        Delivery,
        Pickup
    }

    public class Comanda
    {
        public int Id { get; set; }
        public ICollection<ProdusComanda> Produse { get; set; }
        public Client Client { get; set; }
        public DateTime DataComanda { get; set; }
        public Stari StareComanda { get; set; }
        public Tip TipComanda { get; set; }
    }
}
