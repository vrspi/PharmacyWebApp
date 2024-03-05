using Pharmacy.Models;

namespace Pharmacy.Repositories
{
    public interface IPharmacyRepository
    {
        IList<Pharmacie> GetPharmacieList();
        Pharmacie? GetPharmamacie(int Id);
        bool AddPharmacy(Pharmacie pharmacie);
        bool DeletePharmacy(int Id);
        bool UpdatePharmacie(Pharmacie pharmacieEdited);

    }
}
