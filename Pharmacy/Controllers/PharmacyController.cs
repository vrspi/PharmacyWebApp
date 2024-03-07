using Microsoft.AspNetCore.Mvc;
using Pharmacy.Repositories;
using Pharmacy.Utils;
using Pharmacy.ViewModels;

namespace Pharmacy.Controllers
{
    public class PharmacyController : Controller
    {
        private readonly IPharmacyRepository pharmacyRepository;
        private readonly IPharmacyTools pharmacyTools;

        public PharmacyController(IPharmacyRepository pharmacyRepository,IPharmacyTools pharmacyTools) {
            this.pharmacyRepository = pharmacyRepository;
            this.pharmacyTools = pharmacyTools;
        } 


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            return View();
        }

        [Route("Pharmacy/id")]
        public IActionResult Details(int id)
        {
            return View(pharmacyRepository.GetPharmamacie(id));
        }

        [Route("Pharmacy/AjouterPharmacy")]
        public IActionResult AjouterPharmacy()
        {
            return View();
        }

        [Route("Pharmacy/AjouterPharmacy")]
        [HttpPost]
        public IActionResult AjouterPharmacy(ViewModels.Pharmacie pharmacie)
        {
            
			if (ModelState.IsValid)
            {
                pharmacyRepository.AddPharmacy(pharmacyTools.ConvertFromViewModelPharmacie(pharmacie));
                return Content("Added");
            }

            return View(pharmacie);
        }

    }
}
