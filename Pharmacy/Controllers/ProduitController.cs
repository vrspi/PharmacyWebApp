using Microsoft.AspNetCore.Mvc;
using Pharmacy.Repositories;
using Pharmacy.Utils;
using Pharmacy.ViewModels;

namespace Pharmacy.Controllers
{
    public class ProduitController : Controller
    {
        private readonly IProduitRepository produitRepository;
        private readonly IProduitTools produitTools;

        public ProduitController(IProduitRepository produitRepository, IProduitTools produitTools)
        {
            this.produitRepository = produitRepository;
            this.produitTools = produitTools;
        }

		[Route("Produit/Index")]
		public IActionResult Index()
        {
			var productList = produitRepository.GetProduitList();
			return View(productList);
		}

        

        [Route("Produit/{id}")]
        public IActionResult Details(int id)
        {
			var product = produitRepository.GetProduit(id);
			if (product == null)
			{
				return NotFound();
			}

			return View(product);
		}

        [Route("Produit/AjouterProduit")]
        public IActionResult AjouterProduit()
        {
            return View();
        }

        [HttpPost]
        [Route("Produit/AjouterProduit")]
		public IActionResult AjouterProduit(ViewModels.Produits produitViewModel)
		{
			if (ModelState.IsValid)
			{
				produitRepository.AddProduit(produitTools.ConvertFromViewModelProduit(produitViewModel));
				return RedirectToAction("Index"); // Rediriger vers l'action Index du même contrôleur
			}

			return View(produitViewModel);
		}



	}
}
