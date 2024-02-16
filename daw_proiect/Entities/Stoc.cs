namespace daw_proiect.Entities
{
    public class Stoc
    {
        public int ProdusId { get; set; }
        public int LocatieId { get; set; }
        public int Cantitate {  get; set; }
        public Produs Produs { get; set; }
        public Locatie Locatie { get; set; }
    }
}
