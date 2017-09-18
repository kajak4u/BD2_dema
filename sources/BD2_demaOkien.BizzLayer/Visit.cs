using BD2_demaOkien.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD2_demaOkien.BizzLayer
{
    public class VisitFilterParams
    {
        public DateTime? dateFrom { get; set; }
        public DateTime? dateTo { get; set; }
        public int? doctorID { get; set; }
        public int? patientId { get; set; }
        public string patientPESEL { get; set; }
        public string status { get; set; }
    }

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

        public static IEnumerable<VisitData> GetAll()
        {
            using (var Db = new BD2_demaOkien.Data.BD2_2Db())
            {
                return
                    Db.Visit
                    .Select(visit => new VisitData
                    {
                        visit_id = visit.visit_id,
                        status = visit.status,
                        description = visit.description,
                        diagnosis = visit.diagnosis,
                        registration_date = visit.registration_date,
                        ending_date = visit.ending_date,
                        patientId = visit.Patient.Patient_id,
                        patientName = visit.Patient.First_name + " " + visit.Patient.Last_name,
                        doctorId = visit.Doctor.Worker_id,
                        doctorName = visit.Doctor.First_name + " " + visit.Doctor.Last_name,
                        registerId = visit.Registerer.Worker_id,
                        registererName = visit.Registerer.First_name + " " + visit.Registerer.Last_name
                    })
                    .ToList();
            }
        }

        public static void Submit(int visitId, string interview, string diagnosis)
        {
            using (var Db = new BD2_2Db())
            {
                Visit visit = Db.Visit.Where(v => v.visit_id == visitId).FirstOrDefault();
                visit.status = "ZAK";
                visit.diagnosis = diagnosis;
                visit.description = interview;
                try
                {
                    Db.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                {
                    throw new EntityValidationErrorWrapper(ex);
                }
            }
        }

        public static List<Visit> Get(VisitFilterParams filter)
        {
            using (var Db = new BD2_demaOkien.Data.BD2_2Db())
            {
                IQueryable<Visit> result = Db.Visit
                    .Include(v => v.Patient)
                    .Include(v => v.Registerer)
                    .Include(v => v.Doctor);
                if (filter.doctorID.HasValue)
                    result = result.Where(v => v.Doctor.Worker_id == filter.doctorID.Value);
                if (filter.status != null && filter.status != "")
                    result = result.Where(v => v.status.Equals(filter.status));
                if (filter.patientPESEL != null && filter.patientPESEL != "")
                    result = result.Where(v => v.Patient.PESEL.Equals(filter.patientPESEL));
                if (filter.patientId.HasValue)
                    result = result.Where(v => v.patient_id == filter.patientId);
                if (filter.dateFrom.HasValue)
                    result = result.Where(v => v.ending_date >= filter.dateFrom.Value);
                if (filter.dateTo.HasValue)
                {
                    DateTime endingDate = filter.dateTo.Value.AddDays(1); //bo inaczej bedzie porownywac z np. 01.01.2017 00:00:00 i godzina spieprzy wszystko
                    result = result.Where(v => v.ending_date < endingDate);
                }
                return result.ToList();
            }
        }

        public static IEnumerable<Data.Visit> ForDoctor(int doctorID, DateTime date)
        {
            using (var Db = new BD2_2Db())
            {
                var res = Db.Visit
                    .Where(v => v.doctor_id == doctorID)
                    .Include(v => v.Patient)
                    .ToList() // because LINQ
                    .Where(v => v.ending_date.HasValue
                        && DateTime.Compare(date.Date, v.ending_date.Value.Date) == 0)
                    .ToList();
                return res;
            }
        }

        public static void Cancel(int visit_id)
        {
            using (var Db = new BD2_2Db())
            {
                Visit visit = Db.Visit.Where(v => v.visit_id == visit_id).FirstOrDefault();
                visit.status = "ANUL";
                try
                {
                    Db.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                {
                    throw new EntityValidationErrorWrapper(ex);
                }
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
                try
                {
                    Db.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                {
                    throw new EntityValidationErrorWrapper(ex);
                }
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
                }
                else
                    address = matchAddresses.First();

                patient.Address = address;
                Db.Patient.Add(patient);
                try
                {
                    Db.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                {
                    throw new EntityValidationErrorWrapper(ex);
                }
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
                try
                {
                    Db.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                {
                    throw new EntityValidationErrorWrapper(ex);
                }
            }
        }

        static public void Add(Data.Visit visit)
        {
            using (var Db = new BD2_2Db())
            {
                Db.Visit.Add(visit);
                try
                {
                    Db.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                {
                    throw new EntityValidationErrorWrapper(ex);
                }
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
                try
                {
                    Db.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                {
                    throw new EntityValidationErrorWrapper(ex);
                }
            }
        }
    }

    public class VisitData
    {
        public string description { get; set; }
        public string diagnosis { get; set; }
        public int doctorId { get; set; }
        public string doctorName { get; set; }
        public DateTime? ending_date { get; set; }
        public int patientId { get; set; }
        public string patientName { get; set; }
        public string registererName { get; set; }
        public int registerId { get; set; }
        public DateTime? registration_date { get; set; }
        public string status { get; set; }
        public int visit_id { get; set; }
    }
}
