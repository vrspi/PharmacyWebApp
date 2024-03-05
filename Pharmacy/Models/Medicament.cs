namespace Pharmacy.Models
{
    public class Medicament
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set;}
        public DateTime ModifiedDate { get; set;}

        public Categorie Categorie { get; set; }
        public int CategorieId { get; set;}

    }
}
