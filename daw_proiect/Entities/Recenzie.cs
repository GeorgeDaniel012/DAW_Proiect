using daw_proiect.Entities;

namespace ProiectASP.Entities
{
    public class Recenzie
    {
        public int Id { get; set; }
        public int Nota { get; set; }
        public string Comentariu { get; set; }
        public Produs Produs { get; set; }
        public Client Client { get; set; }
    }
}
