namespace Pharmacy.Models
{
    public class ParaPharmacy
    {
        public int Id
        {
            get; set;
        }
        public string Serial { get; set; }
        public string Adresse { get; set; }
        public string GpsCoord { get; set; }
        public string Image { get; set; }
        public IList<Stock_Produit> Stock_Produits { get; set; }
    } 
}
