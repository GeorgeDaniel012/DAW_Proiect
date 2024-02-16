

namespace daw_proiect.Entities
{
    public class Produs
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public string Name { get; set; }
        public string Descriere { get; set; }
        public Categorie? Categorie { get; set; }
        public int? CategorieId { get; set; }
        public ICollection<ProdusComanda> Comenzi { get; set; }
        public ICollection<Recenzie> Recenzii { get; set; }
        public ICollection<Stoc> Locatii { get; set; }
        public Reteta Reteta { get; set; }
    }
}
