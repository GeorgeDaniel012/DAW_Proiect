using System.Text.Json.Serialization;

namespace daw_proiect.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Email { get; set; }
        [JsonIgnore]
        public ICollection<Comanda> Comenzi { get; set; }
        public AdresaPrincipala? AdresaPrincipala { get; set; }
        [JsonIgnore]
        public ICollection<Recenzie> Recenzi { get; set;}
    }
}
