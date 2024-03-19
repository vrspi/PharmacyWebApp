using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pharmacy.Models;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Pharmacy.Controllers
{
    public class ImageController : Controller
    {
        private readonly Context _context;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public ImageController(Context context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        // GET: Image/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Image/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Pharmacy.Models.Image imageViewModel, IFormFile file)
        {
            try
            {
                if (ModelState.IsValid && file != null && file.Length > 0)
                {
                    // Convertir le fichier téléchargé en tableau de bytes
                    byte[] imageData = null;
                    using (var memoryStream = new MemoryStream())
                    {
                        await file.CopyToAsync(memoryStream);
                        imageData = memoryStream.ToArray();
                    }

                    // Créer une instance de l'objet Image à enregistrer dans la base de données
                    var imageModel = new Pharmacy.Models.Image
                    {
                        
                    };

                    // Ajouter l'image dans la base de données via le contexte
                    _context.images.Add(imageModel);

                    // Enregistrer les modifications dans la base de données
                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }

                // Si le modèle n'est pas valide ou si aucun fichier n'a été téléchargé, retourner à la vue avec le modèle
                return View(imageViewModel);
            }
            catch (Exception ex)
            {
                // Gérer les erreurs
                ModelState.AddModelError(string.Empty, "Une erreur s'est produite lors de l'ajout de l'image.");
                return View(imageViewModel);
            }
        }

        // Méthode pour vérifier si le fichier est une image
        private bool IsImage(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return false;
            }

            string[] permittedExtensions = { ".jpg", ".jpeg", ".png", ".gif" };
            var ext = Path.GetExtension(file.FileName).ToLowerInvariant();
            return permittedExtensions.Contains(ext);
        }
    }
}
