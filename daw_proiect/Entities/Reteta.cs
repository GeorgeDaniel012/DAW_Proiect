namespace daw_proiect.Entities
{

    public class Reteta
    {
        public int Id { get; set; }
        public int ProdusId { get; set; }
        public Produs Produs { get; set; }
        public string Indicatii { get; set; }
    }
}
