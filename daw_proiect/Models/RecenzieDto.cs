using daw_proiect.Entities;

namespace daw_proiect.Models
{
    public class RecenzieDto
    {
        public int Nota { get; set; }
        public string Comentariu { get; set; }
        public int ProdusId { get; set; }
        public int ClientId { get; set; }
    }
}
