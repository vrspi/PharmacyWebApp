namespace Pharmacy.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public Medicament Medicament { get; set; }
        public int MedicamentId { get; set; }
        public Produit Produits { get; set; }
        public int ProduitId { get; set; }

    }
}
