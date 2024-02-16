using System.Text.Json.Serialization;

namespace daw_proiect.Entities
{
    public class AdresaPrincipala
    {
        public int ClientId { get; set; }
        [JsonIgnore]
        public Client Client { get; set; }
        public string? Oras { get; set; }
        public string? Adresa { get; set; }
    }
}
