using Pharmacy.Models;

namespace Pharmacy.Repositories
{
    public interface IProduitRepository
    {
        IList<Produit> GetProduitList();
        Produit? GetProduit(int Id);
        bool AddProduit(Produit produit);
        bool DeleteProduit(int Id);
        bool UpdateProduit(Produit produitEdited);
    }
}
