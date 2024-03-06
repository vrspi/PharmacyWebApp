namespace Pharmacy.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public IList<Pharmacie> Pharmacie { get; set; } 
    }
}
