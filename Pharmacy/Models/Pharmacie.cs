namespace Pharmacy.Models
{
    public class Pharmacie
    {
        public int Id { get; set; }
        public string Serial { get; set; }
        public string Name { get; set; }
        public string Adresse { get; set; }

        public string LatAndLong { get; set; } 
        public string Image { get; set; }
        public IList<Stock> Stocks { get; set; }
        public City City { get; set; }      
        public int  CityId { get; set; }

    }
}
