using BD2_demaOkien.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD2_demaOkien.BizzLayer
{
    static public class Visits
    {
        //takes all patients from db
        public static List<AllPatientsData> getAllPatients()
        {
            using (var Db = new BD2_2Db())
            {
                var patients = from patient in Db.Patient
                               join address in Db.Address
                               on patient.address_id equals address.Address_id
                               select new AllPatientsData
                               {
                                   Patient_id = patient.Patient_id,
                                   First_name = patient.First_name,
                                   Last_name = patient.Last_name,
                                   PESEL = patient.PESEL,
                                   Phone_number = patient.Phone_number,
                                   Address = address.Flat_number != null ? address.City + " " + address.Street + " " + address.House_number + " " + address.Flat_number : address.City + " " + address.Street + " " + address.House_number
                               };
                //var patients = Db.Patient.ToList();
                return patients.ToList();
            }
        }

        //gets one patient from database by all data 
        public static List<AllPatientsData> getPatientByAllData(String FirstName, String LastName, String Pesel)
        {
            using (var Db = new BD2_2Db())
            {
                var patient = from patients in Db.Patient
                              join address in Db.Address
                              on patients.address_id equals address.Address_id
                              where patients.First_name.Contains(FirstName) && patients.Last_name.Contains(LastName) && patients.PESEL.Contains(Pesel)//FirstName == patients.First_name && LastName == patients.Last_name //&& Pesel == patients.PESEL
                              select new AllPatientsData
                              {
                                  Patient_id = patients.Patient_id,
                                  First_name = patients.First_name,
                                  Last_name = patients.Last_name,
                                  PESEL = patients.PESEL,
                                  Address = address.Flat_number != null ? address.City + " " + address.Street + " " + address.House_number + " " + address.Flat_number : address.City + " " + address.Street + " " + address.House_number
                              };
                //var patients = Db.Patient.ToList();
                return patient.ToList();
            }
        }

        public static PatientData getPatientById(int id)
        {
            using (var Db = new BD2_2Db())
            {
                var patient = from patients in Db.Patient
                              join address in Db.Address
                              on patients.address_id equals address.Address_id
                              where patients.Patient_id == id
                              select new PatientData
                              {
                                  Patient_id = patients.Patient_id,
                                  First_name = patients.First_name,
                                  Last_name = patients.Last_name,
                                  PESEL = patients.PESEL,
                                  Phone_number = patients.Phone_number,
                                  City = address.City,
                                  Street = address.Street,
                                  HouseNo = address.House_number,
                                  FlatNo = address.Flat_number
                                  //address = address.Flat_number != null ? address.City + " " + address.Street + " " + address.House_number + " " + address.Flat_number : address.City + " " + address.Street + " " + address.House_number
                              };
                //var patients = Db.Patient.ToList();
                return patient.FirstOrDefault();
            }
        }

        public static void deleteUser(int id)
        {
            using (var Db = new BD2_2Db())
            {
                var patient = Db.Patient.Where(p => p.Patient_id == id).FirstOrDefault();
                if (patient == null)
                    throw new Exception("No such patient!");

                //Db.Address.Remove(add.First()); - adres zostaje w bazie! - co jeśli ktoś inny też go ma?
                Db.Patient.Remove(patient);
                Db.SaveChanges();
            }

        }


        public static void setPatientData(String name, String surname, String pesel, String phone, String city, String street, int houseNo, int? flatNo, int? id)
        {
            Address address = new Address { City = city, Street = street, House_number = houseNo, Flat_number = flatNo };

            Patient patient = new Patient { First_name = name, Last_name = surname, PESEL = pesel, Phone_number = phone };

            using (var Db = new BD2_2Db())
            {
                var matchAddresses = Db.Address
                    .Where(add =>
                         (add.City == null ? address.City == null : add.City.Equals(address.City))
                            && (add.Street == null ? address.Street == null : add.Street.Equals(address.Street))
                            && add.House_number == address.House_number
                            && (!add.Flat_number.HasValue ? !address.Flat_number.HasValue : add.Flat_number.Value == address.Flat_number.Value));
                if (matchAddresses.Count() == 0)
                {
                    Db.Address.Add(address);
                    //Db.SaveChanges(); // ważne!
                }
                else
                    address = matchAddresses.First();

                patient.Address = address;
                Db.Patient.Add(patient);
                Db.SaveChanges();
            }
        }

        public static void editPatientData(String name, String surname, String pesel, String phone, String city, String street, int houseNo, int? flatNo, int id)
        {
            using (var Db = new BD2_2Db())
            {
                var patientData = Db.Patient.Where(p => p.Patient_id == id).FirstOrDefault();
                patientData.First_name = name;
                patientData.Last_name = surname;
                patientData.PESEL = pesel;
                patientData.Phone_number = phone;

                var patientAddress = Db.Address.Where(p => p.Address_id == patientData.address_id).FirstOrDefault();
                patientAddress.City = city;
                patientAddress.Street = street;
                patientAddress.House_number = houseNo;
                patientAddress.Flat_number = flatNo;
                Db.SaveChanges();
            }
        }

        static public void Add(Data.Visit visit)
        {
            using (var Db = new BD2_2Db())
            {
                Db.Visit.Add(visit);
                Db.SaveChanges();
            }
        }

        static public Data.Visit GetByID(int id)
        {
            using (var Db = new BD2_2Db())
            {
                return Db.Visit
                    .Where(v => v.visit_id == id)
                    .Include(visit => visit.Patient)
                    .Include(visit => visit.Doctor)
                    .FirstOrDefault();
            }
        }
        static public void Modify(Visit newVisit)
        {
            using (var Db = new BD2_2Db())
            {
                Db.Entry<Visit>(newVisit).State = System.Data.Entity.EntityState.Modified;
                Db.SaveChanges();
            }
        }
    }

}
