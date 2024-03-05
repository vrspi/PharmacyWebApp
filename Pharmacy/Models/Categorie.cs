namespace Pharmacy.Models
{
    public class Categorie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public IList<Medicament>? medicaments { get; set; }

    }
}
