using Pharmacy.Models;

namespace Pharmacy.Utils
{
    public interface IPharmacyTools
    {
        public Pharmacie ConvertFromViewModelPharmacie(ViewModels.Pharmacie Pharmacy);
        public string GeneratePharmacySerial();

    }
}
