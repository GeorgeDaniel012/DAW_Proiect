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
    [Migration("20240214023759_first_migration")]
    partial class first_migration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("daw_proiect.Entities.AdresaPrincipala", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Oras")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

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

            modelBuilder.Entity("daw_proiect.Entities.Comanda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataComanda")
                        .HasColumnType("datetime2");

                    b.Property<int>("StareComanda")
                        .HasColumnType("int");

                    b.Property<int>("TipComanda")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

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

                    b.Property<string>("Name")
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

            modelBuilder.Entity("daw_proiect.Entities.Recenzie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Continut")
                        .HasColumnType("int");

                    b.Property<int>("ProdusId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProdusId");

                    b.HasIndex("UserId");

                    b.ToTable("Recenzie");
                });

            modelBuilder.Entity("daw_proiect.Entities.User", b =>
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

                    b.ToTable("User");
                });

            modelBuilder.Entity("daw_proiect.Entities.AdresaPrincipala", b =>
                {
                    b.HasOne("daw_proiect.Entities.User", "User")
                        .WithOne("AdresaPrincipala")
                        .HasForeignKey("daw_proiect.Entities.AdresaPrincipala", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("daw_proiect.Entities.Comanda", b =>
                {
                    b.HasOne("daw_proiect.Entities.User", "User")
                        .WithMany("Comenzi")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
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

            modelBuilder.Entity("daw_proiect.Entities.Recenzie", b =>
                {
                    b.HasOne("daw_proiect.Entities.Produs", "Produs")
                        .WithMany()
                        .HasForeignKey("ProdusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("daw_proiect.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produs");

                    b.Navigation("User");
                });

            modelBuilder.Entity("daw_proiect.Entities.Categorie", b =>
                {
                    b.Navigation("Produse");
                });

            modelBuilder.Entity("daw_proiect.Entities.Comanda", b =>
                {
                    b.Navigation("Produse");
                });

            modelBuilder.Entity("daw_proiect.Entities.Produs", b =>
                {
                    b.Navigation("Comenzi");
                });

            modelBuilder.Entity("daw_proiect.Entities.User", b =>
                {
                    b.Navigation("AdresaPrincipala")
                        .IsRequired();

                    b.Navigation("Comenzi");
                });
#pragma warning restore 612, 618
        }
    }
}
