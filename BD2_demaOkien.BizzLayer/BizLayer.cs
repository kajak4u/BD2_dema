using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD2_demaOkien.Data;

namespace BD2_demaOkien
{
    class BizLayer
    {
    public static void Main() { }
    }

    static public class Worker {
        public static Data.Worker getWorker(String userLogin, String userPassword)
        {
            using (var Db = new BD2_2Db())
            {
                var worker = Db.Worker.ToList()
                    .Where(w => w.Login == userLogin && w.Password == userPassword)
                    .FirstOrDefault();
                return worker;
            }
        }
    }

    static public class Visit {
        //takes all patients from db
        public static IQueryable getAllPatients()
        {
            using (var Db = new BD2_2Db())
            {
                var patients = from patient in Db.Patient
                             join address in Db.Address
                             on patient.address_id equals address.Address_id
                             select new
                             {
                                 First_name = patient.First_name,
                                 Last_name = patient.Last_name,
                                 PESEL = patient.PESEL,
                                 address = address.Flat_number != null ? address.City + " " +address.Street + " " + address.House_number + " " + address.Flat_number : address.City + " " + address.Street + " " + address.House_number
                             };
                //var patients = Db.Patient.ToList();
                return patients;
            }
        }

        //gets one patient from database by all data 
        public static IQueryable getPatientByAllData(String FirstName, String LastName, String Pesel)
        {
            using (var Db = new BD2_2Db())
            {
                var patient = from patients in Db.Patient
                               join address in Db.Address
                               on patients.address_id equals address.Address_id
                               where FirstName == patients.First_name && LastName == patients.Last_name //&& Pesel == patients.PESEL
                               select new
                               {
                                   First_name = patients.First_name,
                                   Last_name = patients.Last_name,
                                   PESEL = patients.PESEL,
                                   address = address.Flat_number != null ? address.City + " " + address.Street + " " + address.House_number + " " + address.Flat_number : address.City + " " + address.Street + " " + address.House_number
                               };
                //var patients = Db.Patient.ToList();
                return patient;
            }
        }

    }

    static public class Patient {

    }

    
}
