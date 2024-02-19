using System.Text.Json.Serialization;

namespace daw_proiect.Entities
{

    public class Reteta
    {
        public int Id { get; set; }
        public int ProdusId { get; set; }
        [JsonIgnore]
        public Produs Produs { get; set; }
        public string Indicatii { get; set; }
    }
}
