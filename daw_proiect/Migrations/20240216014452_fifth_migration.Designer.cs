﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using daw_proiect.ContextModels;

#nullable disable

namespace daw_proiect.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240216014452_fifth_migration")]
    partial class fifth_migration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProiectASP.Entities.Locatie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Numar_cladire")
                        .HasColumnType("int");

                    b.Property<string>("Oras")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Strada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Locatii");
                });

            modelBuilder.Entity("ProiectASP.Entities.Recenzie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Comentariu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Nota")
                        .HasColumnType("int");

                    b.Property<int>("ProdusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("ProdusId");

                    b.ToTable("Recenzii");
                });

            modelBuilder.Entity("daw_proiect.Entities.AdresaPrincipala", b =>
                {
                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Oras")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientId");

                    b.ToTable("AdresaPrincipala");
                });

            modelBuilder.Entity("daw_proiect.Entities.Categorie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Denumire")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categorie");
                });

            modelBuilder.Entity("daw_proiect.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("daw_proiect.Entities.Comanda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataComanda")
                        .HasColumnType("datetime2");

                    b.Property<int>("StareComanda")
                        .HasColumnType("int");

                    b.Property<int>("TipComanda")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Comanda");
                });

            modelBuilder.Entity("daw_proiect.Entities.Produs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategorieId")
                        .HasColumnType("int");

                    b.Property<string>("Denumire")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descriere")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategorieId");

                    b.ToTable("Produs");
                });

            modelBuilder.Entity("daw_proiect.Entities.ProdusComanda", b =>
                {
                    b.Property<int>("ProdusId")
                        .HasColumnType("int");

                    b.Property<int>("ComandaId")
                        .HasColumnType("int");

                    b.HasKey("ProdusId", "ComandaId");

                    b.HasIndex("ComandaId");

                    b.ToTable("ProduseComenzi");
                });

            modelBuilder.Entity("ProiectASP.Entities.Recenzie", b =>
                {
                    b.HasOne("daw_proiect.Entities.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("daw_proiect.Entities.Produs", "Produs")
                        .WithMany()
                        .HasForeignKey("ProdusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Produs");
                });

            modelBuilder.Entity("daw_proiect.Entities.AdresaPrincipala", b =>
                {
                    b.HasOne("daw_proiect.Entities.Client", "Client")
                        .WithOne("AdresaPrincipala")
                        .HasForeignKey("daw_proiect.Entities.AdresaPrincipala", "ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("daw_proiect.Entities.Comanda", b =>
                {
                    b.HasOne("daw_proiect.Entities.Client", "Client")
                        .WithMany("Comenzi")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("daw_proiect.Entities.Produs", b =>
                {
                    b.HasOne("daw_proiect.Entities.Categorie", "Categorie")
                        .WithMany("Produse")
                        .HasForeignKey("CategorieId");

                    b.Navigation("Categorie");
                });

            modelBuilder.Entity("daw_proiect.Entities.ProdusComanda", b =>
                {
                    b.HasOne("daw_proiect.Entities.Comanda", "Comanda")
                        .WithMany("Produse")
                        .HasForeignKey("ComandaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("daw_proiect.Entities.Produs", "Produs")
                        .WithMany("Comenzi")
                        .HasForeignKey("ProdusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comanda");

                    b.Navigation("Produs");
                });

            modelBuilder.Entity("daw_proiect.Entities.Categorie", b =>
                {
                    b.Navigation("Produse");
                });

            modelBuilder.Entity("daw_proiect.Entities.Client", b =>
                {
                    b.Navigation("AdresaPrincipala");

                    b.Navigation("Comenzi");
                });

            modelBuilder.Entity("daw_proiect.Entities.Comanda", b =>
                {
                    b.Navigation("Produse");
                });

            modelBuilder.Entity("daw_proiect.Entities.Produs", b =>
                {
                    b.Navigation("Comenzi");
                });
#pragma warning restore 612, 618
        }
    }
}
