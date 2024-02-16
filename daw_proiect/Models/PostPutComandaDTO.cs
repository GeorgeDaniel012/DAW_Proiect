using daw_proiect.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace daw_proiect.Models
{
    public class PostPutComandaDTO
    {
        [NotMapped]
        public List<int> ProduseId { get; set; } = new List<int>();
        public int ClientId { get; set; }
    }
}
