﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pharmacy.Models;

#nullable disable

namespace Pharmacy.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240307085840_Parapharmacy")]
    partial class Parapharmacy
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Pharmacy.Models.Categorie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("Pharmacy.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Libelle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("citys");
                });

            modelBuilder.Entity("Pharmacy.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MedicamentId")
                        .HasColumnType("int");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProduitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MedicamentId");

                    b.HasIndex("ProduitId");

                    b.ToTable("images");
                });

            modelBuilder.Entity("Pharmacy.Models.Medicament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategorieId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategorieId");

                    b.ToTable("medicaments");
                });

            modelBuilder.Entity("Pharmacy.Models.ParaPharmacy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GpsCoord")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Serial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("parapharmacy");
                });

            modelBuilder.Entity("Pharmacy.Models.Pharmacie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LatAndLong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Serial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("pharmacies");
                });

            modelBuilder.Entity("Pharmacy.Models.Produit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Libelle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Prix")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("produits");
                });

            modelBuilder.Entity("Pharmacy.Models.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MedicamentId")
                        .HasColumnType("int");

                    b.Property<int>("PharmacieId")
                        .HasColumnType("int");

                    b.Property<double>("Quantite")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("MedicamentId");

                    b.HasIndex("PharmacieId");

                    b.ToTable("stocks");
                });

            modelBuilder.Entity("Pharmacy.Models.Stock_Produit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ParaPharmacyId")
                        .HasColumnType("int");

                    b.Property<int>("ProduitId")
                        .HasColumnType("int");

                    b.Property<int>("Qte")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParaPharmacyId");

                    b.HasIndex("ProduitId");

                    b.ToTable("stock_produit");
                });

            modelBuilder.Entity("Pharmacy.Models.Image", b =>
                {
                    b.HasOne("Pharmacy.Models.Medicament", "Medicament")
                        .WithMany("Images")
                        .HasForeignKey("MedicamentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pharmacy.Models.Produit", "Produits")
                        .WithMany("Images")
                        .HasForeignKey("ProduitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medicament");

                    b.Navigation("Produits");
                });

            modelBuilder.Entity("Pharmacy.Models.Medicament", b =>
                {
                    b.HasOne("Pharmacy.Models.Categorie", "Categorie")
                        .WithMany("medicaments")
                        .HasForeignKey("CategorieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categorie");
                });

            modelBuilder.Entity("Pharmacy.Models.Pharmacie", b =>
                {
                    b.HasOne("Pharmacy.Models.City", "City")
                        .WithMany("Pharmacie")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Pharmacy.Models.Stock", b =>
                {
                    b.HasOne("Pharmacy.Models.Medicament", "Medicament")
                        .WithMany("Stocks")
                        .HasForeignKey("MedicamentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pharmacy.Models.Pharmacie", "Pharmacie")
                        .WithMany("Stocks")
                        .HasForeignKey("PharmacieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medicament");

                    b.Navigation("Pharmacie");
                });

            modelBuilder.Entity("Pharmacy.Models.Stock_Produit", b =>
                {
                    b.HasOne("Pharmacy.Models.ParaPharmacy", "ParaPharmacy")
                        .WithMany("Stock_Produits")
                        .HasForeignKey("ParaPharmacyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pharmacy.Models.Produit", "Produit")
                        .WithMany("Stock_Produits")
                        .HasForeignKey("ProduitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ParaPharmacy");

                    b.Navigation("Produit");
                });

            modelBuilder.Entity("Pharmacy.Models.Categorie", b =>
                {
                    b.Navigation("medicaments");
                });

            modelBuilder.Entity("Pharmacy.Models.City", b =>
                {
                    b.Navigation("Pharmacie");
                });

            modelBuilder.Entity("Pharmacy.Models.Medicament", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Stocks");
                });

            modelBuilder.Entity("Pharmacy.Models.ParaPharmacy", b =>
                {
                    b.Navigation("Stock_Produits");
                });

            modelBuilder.Entity("Pharmacy.Models.Pharmacie", b =>
                {
                    b.Navigation("Stocks");
                });

            modelBuilder.Entity("Pharmacy.Models.Produit", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Stock_Produits");
                });
#pragma warning restore 612, 618
        }
    }
}
