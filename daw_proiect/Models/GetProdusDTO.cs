using daw_proiect.Entities;

namespace daw_proiect.Models
{
    public class GetProdusDTO
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public string Descriere { get; set; }
        public Categorie? Categorie { get; set; }
        public int? CategorieId { get; set; }
        public ICollection<ProdusComanda> Comenzi { get; set; }
        public ICollection<Recenzie> Recenzii { get; set; }
        public ICollection<Stoc> Locatii { get; set; }
        public Reteta Reteta { get; set; }
    }
}
