namespace Pharmacy.Models
{
    public class Produit
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public float Prix {  get; set; }
        public string Description { get; set; }
        public IList<Image> Images { get; set; }
        public IList<Stock_Produit> Stock_Produits { get; set; }
    }
}
