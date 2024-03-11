using System.ComponentModel.DataAnnotations;

namespace Pharmacy.ViewModels
{
    public class Produits
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Libelle { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        public float Price { get; set; }

        [MaxLength(100, ErrorMessage = "Description cannot be more than 100 characters long.")]
        public string Description { get; set; }
    }
}
