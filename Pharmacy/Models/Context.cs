using Microsoft.EntityFrameworkCore;
using Pharmacy.ViewModels;

namespace Pharmacy.Models
{
    public class Context : DbContext
    {
        public DbSet<Categorie> categories { get; set; }
        public DbSet<Medicament> medicaments { get; set; }
        public DbSet<Pharmacie> pharmacies { get; set; }
        public DbSet<Stock> stocks { get; set; }
        public DbSet<City> citys { get; set; }
        public DbSet<Image> images { get; set; }
        public DbSet<ParaPharmacy> parapharmacy { get; set; }
        public DbSet<Stock_Produit> stock_produit { get; set; }
        public DbSet<Produit> produits { get; set; }



        public Context(DbContextOptions options) : base(options) {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=Pharmacy;Trusted_Connection=true;Encrypt=True;TrustServerCertificate=True;");
        }


    }
}
