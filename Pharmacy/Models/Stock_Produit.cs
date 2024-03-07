namespace Pharmacy.Models
{
    public class Stock_Produit
    {
        public int Id { get; set; }
        public ParaPharmacy ParaPharmacy { get; set; }
        public int ParaPharmacyId { get; set; }
        public Produit Produit { get; set; }
        public int ProduitId { get; set; }
        public int Qte {  get; set; }
    }
}
