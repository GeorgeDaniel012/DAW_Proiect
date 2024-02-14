namespace daw_proiect.Entities
{
    public class ProdusComanda
    {
        public Comanda Comanda { get; set; }
        public int ComandaId { get; set; }
        public Produs Produs { get; set; }
        public int ProdusId { get; set;}
    }
}
