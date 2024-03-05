
using Pharmacy.Models;
using System;

namespace Pharmacy.Utils
{
    public class PharmacyTools : IPharmacyTools
    {
        private readonly Context context;
        private static readonly Random random = new Random();


        public PharmacyTools(Context context) {
            this.context = context;
        }  


        public Pharmacie ConvertFromViewModelPharmacie(ViewModels.Pharmacie PharmacyViewModel)
        {
            Pharmacie pharmacie = new Pharmacie();
            pharmacie.Name = PharmacyViewModel.Name;
            pharmacie.Serial = GeneratePharmacySerial();
            pharmacie.Adresse = PharmacyViewModel.Address;
            pharmacie.LatAndLong = PharmacyViewModel.Latitude + "&" + PharmacyViewModel.Longitude;


            return pharmacie;
            
        }

        public string GeneratePharmacySerial()
        {
            string Serial = "";
            do
            {
                var part1 = GenerateRandomString(6, "abcdefghijklmnopqrstuvwxyz");
                var part2 = GenerateRandomString(6, "abcdefghijklmnopqrstuvwxyz");
                var part3 = GenerateRandomString(6, "abcdefghijklmnopqrstuvwxyz0123456789");

                Serial = $"{part1}-{part2}-{part3}";
            } while (context.pharmacies.Any(p => p.Serial == Serial));


            return Serial;

        }
        private string GenerateRandomString(int length, string chars)
        {
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
