using BD2_demaOkien.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD2_demaOkien.BizzLayer
{
    public class Patients
    {
        public static Data.Patient getByPESEL(string PESEL)
        {
            using (var Db = new BD2_2Db())
            {
                var worker = Db.Patient
                    .Where(p => p.PESEL.Equals(PESEL))
                    .FirstOrDefault();
                return worker;
            }
        }

        public static Patient GetByID(int id)
        {
            using (var Db = new BD2_2Db())
            {
                var patient = Db.Patient
                    .Where(p => p.Patient_id == id)
                    .FirstOrDefault();
                return patient;
            }
        }
        public static bool CanDelete(int id)
        {
            using (var Db = new BD2_2Db())
            {
                var visits = Db.Patient.Where(p => p.Patient_id == id).SelectMany(p => p.Visit).ToList();
                return visits.Count == 0;
            }
        }
    }
}
