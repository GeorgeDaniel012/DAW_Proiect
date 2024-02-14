namespace daw_proiect.Entities
{
    public class Categorie
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public ICollection<Produs> Produse { get; set; }
    }
}
