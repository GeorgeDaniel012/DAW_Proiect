using daw_proiect.Entities;
using Microsoft.EntityFrameworkCore;

namespace daw_proiect.ContextModels
{
    public class Context : DbContext
    {
        public DbSet<Client> Client { get; set; }
        public DbSet<Produs> Produs { get; set; }
        public DbSet<Comanda> Comanda { get; set; }
        public DbSet<Recenzie> Recenzie { get; set; }
        public DbSet<ProdusComanda> ProduseComenzi { get; set; }
        public Context(DbContextOptions<Context> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //one to one
            //Utilizator - AdresaPrincipala

            modelBuilder.Entity<AdresaPrincipala>().HasKey(adr => new { adr.ClientId });

            modelBuilder.Entity<AdresaPrincipala>()
                .HasOne(adr => adr.Client)
                .WithOne(user => user.AdresaPrincipala);

            //one to many
            //Comanda - Utilizator

            modelBuilder.Entity<Client>()
                .HasMany(cli => cli.Comenzi)
                .WithOne(com => com.Client);

            //Categorie - Produs

            modelBuilder.Entity<Categorie>()
                .HasMany(cat => cat.Produse)
                .WithOne(prod => prod.Categorie);

            //many to many
            //Produs - Comanda (prin ProdusComanda)

            modelBuilder.Entity<ProdusComanda>().HasKey(prodcom => new { prodcom.ProdusId, prodcom.ComandaId });

            modelBuilder.Entity<ProdusComanda>()
                        .HasOne(prodcom => prodcom.Produs)
                        .WithMany(prod => prod.Comenzi)
                        .HasForeignKey(prodcom => prodcom.ProdusId);

            modelBuilder.Entity<ProdusComanda>()
                        .HasOne(prodcom => prodcom.Comanda)
                        .WithMany(prod => prod.Produse)
                        .HasForeignKey(prodcom => prodcom.ComandaId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
