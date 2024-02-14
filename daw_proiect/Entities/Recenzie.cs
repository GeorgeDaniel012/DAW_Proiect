namespace daw_proiect.Entities
{
    public class Recenzie
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public Produs Produs { get; set; }
        public int Rating { get; set; }
        public int Continut { get; set; }
    }
}
