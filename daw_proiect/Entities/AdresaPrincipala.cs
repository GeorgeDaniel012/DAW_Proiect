namespace daw_proiect.Entities
{
    public class AdresaPrincipala
    {
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public string Oras { get; set; }
        public string Adresa { get; set; }
    }
}
