using Microsoft.EntityFrameworkCore;
using Pharmacy.Models;
using Pharmacy.ViewModels;

namespace Pharmacy.Repositories
{
    public class ProduitRepository : IProduitRepository
    {
        public readonly Context _context;

        public ProduitRepository(Context context)
        {
            _context = context;
        }

        public bool AddProduit(Produit produit)
        {
            try
            {
                _context.produits.Add(produit);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public bool DeleteProduit(int Id)
        {
            try
            {
                Produit? produitToDelete = _context.produits.Find(Id);

                if (produitToDelete != null)
                {
                    _context.produits.Remove(produitToDelete);
                    _context.SaveChanges();

                    return true;
                }

                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public Produit? GetProduit(int Id)
        {
            return _context.produits.Find(Id);
        }

        public IList<Produit> GetProduitList()
        {
            return _context.produits.ToList();
        }

        public bool UpdateProduit(Produit produitEdited)
        {
            try
            {
                _context.produits.Attach(produitEdited);
                _context.Entry(produitEdited).State = EntityState.Modified;
                _context.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }
}
