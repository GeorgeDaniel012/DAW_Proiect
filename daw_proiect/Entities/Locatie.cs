﻿namespace daw_proiect.Entities
{
    public class Locatie
    {
        public int Id { get; set; }
        public string Oras { get; set; }
        public string Strada { get; set; }
        public int Numar_cladire { get; set; }
        public ICollection<Stoc> Produse { get; set; }

    }
}
