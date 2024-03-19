using Pharmacy.Models;
using Pharmacy.Repositories;
using Pharmacy.Utils;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Context>();
builder.Services.AddScoped<IPharmacyRepository, PharmacyRepository>();
builder.Services.AddScoped<IPharmacyTools, PharmacyTools>();
builder.Services.AddScoped<IProduitRepository, ProduitRepository>();
builder.Services.AddScoped<IProduitTools, ProduitTools>();
builder.Services.AddScoped<IImageRepository, ImageRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Création d'une instance d'image de produit
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<Context>();
/*    var imageMedicament = new ImageMedicament
    {
        medicament = new Medicament
        {
            Name = "dlmnk",
            Description = "Description du medicament",
            CategorieId = 1

        },
      // Spécifiez le chemin de votre image du produit


    };

    context.images.Add(imageMedicament);*/
    /*   var newCategory = new Categorie
       {
           Name = "Nouvelle catégorie",
           Description = "Description de la nouvelle catégorie"
       };

       context.categories.Add(newCategory);*/

    Console.WriteLine("Image medicament créée avec succès !");
}

app.Run();
