using daw_proiect.Entities;
using Microsoft.EntityFrameworkCore;


namespace daw_proiect.ContextModels
{
    public class Context : DbContext
    {
        public DbSet<Client> Client { get; set; }
        public DbSet<Produs> Produs { get; set; }
        public DbSet<Comanda> Comanda { get; set; }
        public DbSet<Locatie> Locatie { get; set; }
        public DbSet<Recenzie> Recenzie { get; set; }
        public DbSet<Reteta> Reteta { get; set; }
        public DbSet<ProdusComanda> ProduseComenzi { get; set; }
        public DbSet<AdresaPrincipala> AdresaPrincipala { get; set; }
        public Context(DbContextOptions<Context> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            //one to one
            //Client - AdresaPrincipala

            modelBuilder.Entity<AdresaPrincipala>().HasKey(adr => new { adr.ClientId });

            modelBuilder.Entity<AdresaPrincipala>()
                .HasOne(adr => adr.Client)
                .WithOne(user => user.AdresaPrincipala);

            //Produs-Reteta
            modelBuilder.Entity<Reteta>().HasKey(ret => new { ret.ProdusId });

            modelBuilder.Entity<Reteta>()
                .HasOne(ret => ret.Produs)
                .WithOne(prod => prod.Reteta);

            //one to many
            //Comanda - Utilizator

            modelBuilder.Entity<Client>()
                .HasMany(cli => cli.Comenzi)
                .WithOne(com => com.Client);

            //Categorie - Produs

            modelBuilder.Entity<Categorie>()
                .HasMany(cat => cat.Produse)
                .WithOne(prod => prod.Categorie);

            //Produs - Recenzie
            modelBuilder.Entity<Produs>()
                .HasMany(pro => pro.Recenzii)
                .WithOne(rec => rec.Produs)
                .HasForeignKey(r => r.ProdusId);

            //Client - Recenzie
            modelBuilder.Entity<Client>()
              .HasMany(cli => cli.Recenzi)
              .WithOne(rec => rec.Client)
              .HasForeignKey(r => r.ClientId);

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

            //Produs - Locatie (prin Stoc)
            modelBuilder.Entity<Stoc>().HasKey(prodloc => new { prodloc.ProdusId, prodloc.LocatieId });

            modelBuilder.Entity<Stoc>()
                        .HasOne(prodloc => prodloc.Produs)
                        .WithMany(prod => prod.Locatii)
                        .HasForeignKey(prodloc => prodloc.ProdusId);

            modelBuilder.Entity<Stoc>()
                        .HasOne(prodloc => prodloc.Locatie)
                        .WithMany(prod => prod.Produse)
                        .HasForeignKey(prodloc => prodloc.LocatieId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
