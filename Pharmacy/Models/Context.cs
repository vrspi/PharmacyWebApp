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



        public Context(DbContextOptions options) : base(options) {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=Pharmacy;Trusted_Connection=true;Encrypt=True;TrustServerCertificate=True;");
        }


    }
}
