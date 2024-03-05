using Pharmacy.Models;

namespace Pharmacy.Repositories
{
    public class PharmacyRepository : IPharmacyRepository
    {
        public readonly Context c;

        public PharmacyRepository(Context context)
        {
            c = context;
        }
        public bool AddPharmacy(Pharmacie pharmacie)
        {
            try {
                c.pharmacies.Add(pharmacie);
                c.SaveChanges();
                return true;
            }
            catch (Exception ee)
            {
                throw;
            }
            

        }
        public bool DeletePharmacy(int Id)
        {
            try
            {
                Pharmacie? Wanted = c.pharmacies.Find(Id);
                if(Wanted != null)
                {
                c.pharmacies.Remove(Wanted);
                c.SaveChanges();
                }
               
                return true;


            }
            catch (Exception e) { return false; }
        }

        public IList<Pharmacie> GetPharmacieList()
        {

            return c.pharmacies.ToList();

        }

        public Pharmacie? GetPharmamacie(int Id)
        {
            return c.pharmacies.Find(Id);
        }

        public bool UpdatePharmacie(Pharmacie pharmacieEdited)
        {
            try
            {
                var Pharmacy = c.pharmacies.Attach(pharmacieEdited);
                Pharmacy.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                c.SaveChanges();

                return true;


            }
            catch (Exception e) { return false; }

        }
    }
}
