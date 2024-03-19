namespace Pharmacy.Models
{
    public class ImageMedicament : Image
    {
        public int Id { get; set; }
        public Medicament medicament { get; set; }
        public int MedicamentId { get; set; }
    }
}
