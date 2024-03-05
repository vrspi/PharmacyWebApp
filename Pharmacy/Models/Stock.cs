namespace Pharmacy.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public Pharmacie Pharmacie { get; set; }

        public int PharmacieId { get; set; }

        public Medicament Medicament { get; set; }  
        public int MedicamentId { get; set; }
        
        public double Quantite { get; set; }

    }
}
