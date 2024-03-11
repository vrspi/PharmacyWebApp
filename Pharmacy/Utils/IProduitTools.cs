using Pharmacy.Models;

namespace Pharmacy.Utils
{
    public interface IProduitTools
    {
        public Produit ConvertFromViewModelProduit(ViewModels.Produits Produit);

    }
}
