using Pharmacy.Models;
using Pharmacy.ViewModels;

namespace Pharmacy.Utils
{
    public class ProduitTools : IProduitTools
    {
        private readonly Context _context;
        public ProduitTools(Context context)
        {
            this._context = context;
        }
        public Produit ConvertFromViewModelProduit(Produits produitViewModel)
        {

            Produit produit = new Produit();
            produit.Libelle = produitViewModel.Libelle;
            produit.Prix = produitViewModel.Price;
            produit.Description = produitViewModel.Description;

            return produit;
        }
    }
}
