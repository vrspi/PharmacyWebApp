namespace Pharmacy.Models
{
    public class ImageProduit : Image
    {
        public int Id { get; set; }
        public Produit Produit { get; set; }
        public int ProduitId { get; set; }
    }
}
